   M S B A M L   `   `   `  ����E  AMayProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MayProject.PagesMayProject.Pages  5      'clr-namespace:MayProject
MayProject  5      #    MayProject.Pages.BookSideMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:MayProject.Pages     5      )projclr-namespace:MayProject     5      ���	#FF213869  � 	Resources  5
      $   MayProject.BorderClipConverter   BorderClipConverter  RoundCorners �� Property �� Value �� 
TargetType ��Name �� CornerRadius J� Clip `� 	Converter �� Path	 �� RelativeSource��%0  &	        &	      7     5   
   6#   �� 5   
   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ ButtonBorder��6!   $��0q�67   $	 180��6K   ���	#FFECEBE7$��60��6u   $��60��6�   ._�5      �� $��Center=�6/   $��Center=�6J    5      `� 5   "   8   .1�5   &   �� $ ActualWidth�6.   	 5      �� *Self+�� 5   &   $ ActualHeight�6.   	 5      �� *Self+�� 5   &   $ CornerRadius�6.   	 5      �� *Self+5   #   5      5      5      5       5!      .��5"      � $��	10,0,10,0q�6   
 � RowDefinitions
 5#   
   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6   �� 5&      $
��Auto �6   �� 5'      $
��Auto �6   �� 5(      $
��Auto �6   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   .+�5/   
   �� $��Chapters��6   $��0��6$   $��25(�61   $	��Top=�6?   
�������$��Center=�6k   A� 50   
   -   5        $��SideMenu_Chapters��50       A� Columns$ 4��6/   $��1��6;   �� 51   
   $��
Characters��6   $��2��6&   $��25(�63   
�������$��Center=�6U   A� 52   
   -   5        $��SideMenu_Characters��52      $ 2��61   $��3��6=   �� 53   
   $��	Locations��6   $��4��6%   $��25(�62   
�������$��Center=�6T   A� 54   
   -   5        $��SideMenu_Locations��54      $ 2��60   $��5��6<   �� 55   
   $
��Maps��6   $��6��6    $��25(�6-   
�������$��Center=�6O   �� 56   
   -   5        $��SideMenu_Maps��56      $��7��6*   �� 57   
   $��Notes��6   $��8��6!   $��25(�6.   
�������$��Center=�6O   �� 58   
   -   5        $��SideMenu_Notes��58      $��9��6+   59      5:      