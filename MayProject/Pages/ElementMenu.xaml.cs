﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;
using System.IO;
using MayProject;
using MayProject.Controller;
using MayProject.DataModel;
using MayProject.Contracts;
using System.Reflection;
using System.ComponentModel;

namespace MayProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для BookMenu.xaml
    /// </summary>
    public partial class ElementMenu : UserControl
    {
        private IEnumerable<IElement> _elements;
        private MainWindow _window;
        private Book _book;

        public ElementMenu(IEnumerable<IElement> elements)
        {
            _elements = elements;
            InitializeComponent();
            Visualize();
        }

        public ElementMenu(IEnumerable<IElement> elements, MainWindow window)
        {
            _elements = elements;
            _window = window;
            InitializeComponent();
            Visualize();
        }

        private void Visualize()
        {
            Container.Children.Clear();
            foreach (IElement element in _elements)
            {
                if (element is IIllustratable)
                    Container.Children.Add(CreateIllustrationPlate(element as IIllustratable));
                else
                    Container.Children.Add(CreateTextPlate(element as IPlainTextElement));
            }
            Container.Children.Add(CreateNewElementPlate());
        }

        private Button CreateIllustrationPlate(IIllustratable element)
        {
            BitmapImage img;
            if (element.Illustrations.Count > 0)
                img = element.Illustrations[element.Illustrations.Count - 1].ToBitmapImage();
            else
            {
                if (element is Book)
                    img = Properties.Resources.defaultIllustration.ToBitmapImage();
                else if (element is Character)
                    img = Properties.Resources.avatar.ToBitmapImage();
                else if (element is Location)
                    img = Properties.Resources.park.ToBitmapImage();
                else
                    img = Properties.Resources.defaultIllustration.ToBitmapImage();
            }
            Button plate = CreatePlateTemplate();

            Image image = new Image();
            image.Source = img;

            Label label = new Label();
            label.VerticalAlignment = VerticalAlignment.Center;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Content = element.Title;

            plate.Content = CreateIllustrationGrid(image, label);
            plate.DataContext = element;
            plate.Click += Plate_Click;

            return plate;
        }

        private void Plate_Click(object sender, RoutedEventArgs e)
        {
            OpenElementPage((sender as Button).DataContext as IElement);
        }

        private Button CreateTextPlate(IPlainTextElement element)
        {
            Button plate = CreatePlateTemplate();

            Label label = new Label();
            label.FontSize = 30;
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Margin = new Thickness(5, 5, 0, 0);
            label.Content = element.Title;

            TextBlock textBlock = new TextBlock();
            textBlock.FontSize = 25;
            textBlock.Margin = new Thickness(5);
            textBlock.Text = element.Text;
            textBlock.TextWrapping = TextWrapping.Wrap;
            StackPanel panel = new StackPanel();
            panel.Children.Add(textBlock);

            plate.Content = CreateTextGrid(label, panel);
            plate.Click += Plate_Click;
            plate.DataContext = element;

            return plate;
        }

        private Button CreateNewElementPlate()
        {
            Button plate = CreatePlateTemplate();
            Image newElementIcon = new Image();
            newElementIcon.Source = Properties.Resources.plus.ToBitmapImage();
            plate.Content = newElementIcon;
            plate.Click += (object sender, RoutedEventArgs e) => { CreateNewElement(); };
            return plate;
        }

        private Button CreatePlateTemplate()
        {
            StringBuilder buttonXaml = new StringBuilder();
            buttonXaml.Append(@"<Button xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' 
                                        xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' ");
            buttonXaml.Append("Margin = '20' FontSize = '30' MaxWidth = '200'>");
            buttonXaml.Append("</Button>");

            return XamlReader.Parse(buttonXaml.ToString()) as Button;
        }
        
        private Grid CreateIllustrationGrid(Image image, Label label)
        {
            Grid grid = new Grid();
            Viewbox viewbox = new Viewbox();
            viewbox.Child = label;
            RowDefinition firstRow = new RowDefinition();
            firstRow.Height = GridLength.Auto;
            RowDefinition secondRow = new RowDefinition();
            secondRow.Height = new GridLength(0.3, GridUnitType.Star);
            grid.RowDefinitions.Add(firstRow);
            grid.RowDefinitions.Add(secondRow);
            Grid.SetRow(image, 0);
            Grid.SetColumn(image, 0);
            Grid.SetRow(viewbox, 1);
            Grid.SetColumn(viewbox, 1);

            grid.Children.Add(image);
            grid.Children.Add(viewbox);

            return grid;
        }

        private Grid CreateTextGrid(Label label, StackPanel note)
        {
            Grid grid = new Grid();
            RowDefinition firstRow = new RowDefinition();
            firstRow.Height = GridLength.Auto;
            RowDefinition secondRow = new RowDefinition();
            secondRow.Height = new GridLength(1, GridUnitType.Star);
            grid.RowDefinitions.Add(firstRow);
            grid.RowDefinitions.Add(secondRow);
            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 0);
            Grid.SetRow(note, 1);
            Grid.SetColumn(note, 1);

            grid.Children.Add(label);
            grid.Children.Add(note);

            return grid;
        }

        private void OpenElementPage(IElement element)
        {
            if (_window != null && element is Book)
            {
                _window.SideMenu.Visibility = Visibility.Visible;
                PopulateSideMenu(element as Book);
            }
                if (element is Book)
                PageSwitcher.Switch(new CategoriesMenu(element as Book));
            if (element is Note)
                PageSwitcher.Switch(new NotePage(_elements, element));
            if (element is Chapter)
                PageSwitcher.Switch(new ChapterPage(_elements, element));
            if (element is Character)
                PageSwitcher.Switch(new CharacterProfile(_elements, element));
            if (element is Location)
                PageSwitcher.Switch(new LocationPage(_elements, element));
        }

        private void PopulateSideMenu(Book book)
        {
            _book = book;
            _window.SideMenu_Chapters.Children.Clear();
            _window.SideMenu_Characters.Children.Clear();
            _window.SideMenu_Locations.Children.Clear();
            _window.SideMenu_Maps.Children.Clear();
            _window.SideMenu_Notes.Children.Clear();

            foreach (Chapter chapter in book.Chapters)
            {
                Button plate = new Button();
                plate.MaxWidth = 50;
                plate.Margin = new Thickness(2);
                plate.Background = new SolidColorBrush(Color.FromRgb(169, 169, 169));
                plate.Content = book.Chapters.IndexOf(chapter) + 1;
                _window.SideMenu_Chapters.Children.Add(plate);
            }
            foreach (Character character in book.Characters)
            {
                Button plate = CreateIllustrationPlate(character);
                plate.Margin = new Thickness(2);
                plate.MaxWidth = 80;
                plate.FontSize = 18;
                plate.Style = _window.FindResource("RoundCorners") as Style;
                plate.Click -= Plate_Click;
                plate.PreviewMouseMove += Plate_MouseMove;
                plate.DataContext = character;
                _window.SideMenu_Characters.Children.Add(plate);
            }
            foreach (Location location in book.Locations)
            {
                Button plate = CreateIllustrationPlate(location);
                plate.Margin = new Thickness(2);
                plate.MaxWidth = 80;
                plate.FontSize = 18;
                plate.Style = _window.FindResource("RoundCorners") as Style;
                plate.Click -= Plate_Click;
                plate.PreviewMouseMove += Plate_MouseMove;
                plate.DataContext = location;
                _window.SideMenu_Locations.Children.Add(plate);
            }
            Button relationsMap = new Button();
            relationsMap.Content = "Relations Map";
            relationsMap.Background = new SolidColorBrush(Color.FromRgb(128, 128, 128));
            relationsMap.FontSize = 18;
            relationsMap.Margin = new Thickness(2);
            Button eventsMap = new Button();
            eventsMap.Content = "Events Map";
            eventsMap.Background = new SolidColorBrush(Color.FromRgb(128, 128, 128));
            eventsMap.FontSize = 18;
            eventsMap.Margin = new Thickness(2);
            _window.SideMenu_Maps.Children.Add(relationsMap);
            _window.SideMenu_Maps.Children.Add(eventsMap);

            foreach (Note note in book.Notes)
            {
                Button plate = new Button();
                plate.Background = new SolidColorBrush(Color.FromRgb(128, 128, 128));
                plate.Content = note.Title;
                plate.FontSize = 18;
                _window.SideMenu_Notes.Children.Add(plate);
            }

        }

        private void Plate_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DataObject data = new DataObject();
                data.SetData("IIllustratable", (sender as Button).DataContext as IIllustratable);

                DragDrop.DoDragDrop(this, data, DragDropEffects.Move | DragDropEffects.Copy);

            }
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            base.OnGiveFeedback(e);
            if (e.Effects.HasFlag(DragDropEffects.Copy))
            {
                Mouse.SetCursor(Cursors.Cross);
            }
            else if (e.Effects.HasFlag(DragDropEffects.Move))
            {
                Mouse.SetCursor(Cursors.Pen);
            }
            else
            {
                Mouse.SetCursor(Cursors.No);
            }
            e.Handled = true;
        }

        private void CreateNewElement()
        {
            switch (_elements.GetType().GetGenericArguments()[0].Name.ToString())
            {
                case "Book":
                    {
                        CreateNewBook();
                        break;
                    }
                case "Note":
                    {
                        CreateNewNote();
                        break;
                    }
                case "Character":
                    {
                        CreateNewCharacter();
                        break;
                    }
                case "Chapter":
                    {
                        CreateNewChapter();
                        break;
                    }
                case "Location":
                    {
                        CreateNewLocation();
                        break;
                    }
            }
        }

        private void CreateNewBook()
        {
            NewElementWindow newBookWindow = new NewElementWindow();
            newBookWindow.ShowDialog();
            string newBookTitle = newBookWindow.NewElementTitle;
            if (!string.IsNullOrEmpty(newBookTitle))
            {
                Bookshelf.Books.Add(newBookTitle);
                Bookshelf.Books.Save();
            }
            Visualize();
        }

        private void CreateNewNote()
        {
            PageSwitcher.Switch(new NotePage(_elements));
        }

        private void CreateNewCharacter()
        {
            NewElementWindow newCharacterWindow = new NewElementWindow();
            newCharacterWindow.ShowDialog();
            string newCharacterName = newCharacterWindow.NewElementTitle;
            if (!string.IsNullOrEmpty(newCharacterName))
            {
                Bookshelf.Books.Find(book => book.Characters == _elements).AddCharacter(newCharacterName);
                Bookshelf.Books.Save();
            }
            Visualize();
        }

        private void CreateNewChapter()
        {
            NewElementWindow newChapterWindow = new NewElementWindow();
            newChapterWindow.ShowDialog();
            string newChapterTitle = newChapterWindow.NewElementTitle;
            if (!string.IsNullOrEmpty(newChapterTitle))
            {
                Bookshelf.Books.Find(book => book.Chapters == _elements).AddChapter(newChapterTitle);
                Bookshelf.Books.Save();
            }
            Visualize();
        }

        private void CreateNewLocation()
        {
            NewElementWindow newLocationWindow = new NewElementWindow();
            newLocationWindow.ShowDialog();
            string newLocationTitle = newLocationWindow.NewElementTitle;
            if (!string.IsNullOrEmpty(newLocationTitle))
            {
                Bookshelf.Books.Find(book => book.Locations == _elements).AddLocation(newLocationTitle);
                Bookshelf.Books.Save();
            }
            Visualize();
        }

        private void ContextMenuButton_MouseOver(object sender, RoutedEventArgs e)
        { 
            (sender as Button).Background = new SolidColorBrush(Color.FromArgb(255, 178, 34, 34));
            ((((sender as Button).Parent as Grid).Children
                .Cast<UIElement>()
                .First(x => x.GetType() == typeof(Viewbox)) as Viewbox).Child as TextBlock)
                .Text = (sender as Button).DataContext as string;
        }

        private void ContextMenuButton_MouseLeave(object sender, RoutedEventArgs e)
        {
            (sender as Button).Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            ((((sender as Button).Parent as Grid).Children
                .Cast<UIElement>()
                .First(x => x.GetType() == typeof(Viewbox)) as Viewbox).Child as TextBlock)
                .Text = string.Empty;
        }

        private void ButtonDeleteElement_Click(object sender, RoutedEventArgs e)
        {
            (((((sender as Button)
                .Parent as Grid)
                .TemplatedParent as ContextMenu)
                .PlacementTarget as Border)
                .DataContext as IElement).Delete();
            Bookshelf.Books.Save();
            (((sender as Button)
                .Parent as Grid)
                .TemplatedParent as ContextMenu).Visibility = Visibility.Collapsed;
            Visualize();
        }

        private void ButtonAddIllustration_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonRename_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
