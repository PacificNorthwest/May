   M S B A M L   `   `   `  ����E  AMayProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MayProject.PagesMayProject.Pages  5      'clr-namespace:MayProject
MayProject  5           MayProject.Pages.EventNode   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:MayProject.Pages     5      )projclr-namespace:MayProject     5      
������ $��0q�5	   P   $	��400��6d   $	��400��6s   z�5
      T� 5   
     � 	Resources  5      ,  &MayProject.EventTitlePositionConverter   EventTitlePositionConverter  EventPlateStyle �� Property �� Value �� 
TargetType ��Name �� CornerRadius  LocationPlateStyle �� Triggers P� Property P� Value��%�  &	        &	      &	       5   
   6+   �� 5   
   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ Border��6!   $��0q�61   $	 180��6E   
�������._�5      �� $��Center=�6/   $��Center=�6J   5      5      5      5      �� 5   
   .�5      ��  � ��
 ���� 63   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� 
���   �$��0q�65   #��z��6I   ._�5       �� $��Center=�6/   $��Center=�6J   5!      5"      5$       5%      P� 5&       �@J�IsMouseOver . . �5'      ��  � ��
 ���� 6;   5(      5*      5+      .��5,      � -   5        $��Plate��5,      	 � RowDefinitions	 5-   
   �� 5.      $
��0.4* �6   �� 5/      $
��Auto �6   �� 50      $
��Auto �6   �� 51      $
��Auto �6   
 � ColumnDefinitions
 53   
   �� 54      $��0.35* �6   �� 55      .+�57   
   �� -   5        $��
EventTitle��57      $��0��58      $��2��6   $��1��60   $��2��6@   $��Center=�59      $��Center=�6/   $��30(�5:       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�65    �� TextAlignment$ Center=�6I   $
��Auto��5;      
������ $��0q�5<   +   ��5=      �� *ActualHeight+ �� ElementName$ DescriptionPlate�� �� 	Converter# [  �� 5>   
   -   5        $��DescriptionPlate��5>      $��1��6)   $��3��66   $��1��6G   #��[ 5?      $	��170��5@      $	��180��6    $
��Auto��60   $��Center=�5A      $��Center=�6,   $��40,0,0,0q�5B      ��5@   =   �� *ActualWidth+ �� RelativeSource �� *Self+.��5C      �� -   5        $��EventDescription��5C      
������ $��20(�6G   $��0q�6U   $
 Wrap=�6i    . $��20, 60q�6�   5D      �� 5E   
   $��1��6   $��0��6   #��[ 5F      $��75��5G      $��75��6   $
��Auto��6.   $	��110��6;   $��Center=�5H      $��Center=�6,   $��	0,0,-70,0q�5I      ��5G   J   �� *ActualWidth+ �� *Self+.��5J      �� -   5        $��EventCharacters��5J      
������ $��0q�6F   $
 Wrap=�6Z    . $��10, 30q�6�   5K      �� 5L   
   $��2��6   $��0��6   #��[ 5M      $��75��5N      $��75��6   $
��Auto��6.   $	��110��6;   $��Center=�5O      $��Center=�6,   $��	0,0,-10,0q�5P      ��5N   J   �� *ActualWidth+ �� *Self+.��5Q      �� -   5        $��EventLocation��5Q      
������ $��0q�6D   $
 Wrap=�6X    . $��10, 30q�6�   5R      �� 5S   
   $��3��6   $��0��6   #��[ 5T      $��75��5U      $��75��6   $
��Auto��6.   $	��110��6;   $��Center=�5V      $��Center=�6,   $��	0,0,-70,0q�5W      ��5U   J   �� *ActualWidth+ �� *Self+.��5X      �� -   5        $��	EventTime��5X      
������ $��0q�6@   $
 Wrap=�6T    . $��10, 30q�6}   5Y      5Z      5[      