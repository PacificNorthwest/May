   M S B A M L   `   `   `  ����E  AMayProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MayProject.PagesMayProject.Pages  5      'clr-namespace:MayProject
MayProject  5      "    MayProject.Pages.ElementMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:MayProject.Pages     5      )projclr-namespace:MayProject     5        � 	Resources  5	      $   MayProject.BorderClipConverter   BorderClipConverter  ContextMenuButton �� Property �� Value �� 
TargetType �� CornerRadius �� 
TargetType ��Name J� Clip `� 	Converter	 �� Path
 �� RelativeSource � ContextMenu ��Name �� 	Placement �� VerticalOffset �� HorizontalOffset � RowDefinitions � ColumnDefinitions ��Name � DataContext��%�  &	        &	      '�� y    7   7  7  7    5
   
   6#   �� 5   
   .�5      ��  � ��
 �����63   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� 
���   �$��1q�65   $ 90��6I   #��z��6[   ._�5      �� $��Center=�6/   $��Center=�6J   5      5      5      �� 5       � ��$ 25(�61   �� 5       � ��$
 Bold"�63   -   5        5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ ButtonBorder��6!   $��0q�67   $ 10��6K   
�������$	��300��6s   ._�5       �� $��Center=�6/   $��Center=�6J    5!      `� 5"   "   8   .1�5#   &   �� $	 ActualWidth�6.   
 5$      �� *Self+�� 5%   &   $	 ActualHeight�6.   
 5&      �� *Self+�� 5'   &   $	 CornerRadius�6.   
 5(      �� *Self+5)   #    5+      �� 5,   "   $ BookContextMenu��6.   $ 
MousePoint=�6G   $
 -100��6^   $	 -60��6t   $	��120��6�   $	��120��6�   ��5-   &   �� 5.   *   " ��6:   .R�5/   .   �  50   2   �� 51   6   $��40 �6D   �� 52   6   $
��Auto �6D   $��40��6R   �� 53   6   $
��Auto �6D   $��40��6R    56   2   �� 57   6   $��40 �6G   $��40��6R   �� 58   6   $��40 �6G   $��40��6R   �� 59   6   $��40 �6G   $��40��6R   .+�5;   2   (� $
��Left=�6:   $��0��6U   $��0��6b   $��3��6r   .��5<   6   �� $ ContextMenuDescription��6@   
�������6`   5=   3   �� 5>   2   $��ButtonDeleteElement��69   -   5        8�� $��0��5>      $��1��6�   $��2��6�   $��0, 20, 0, 20q�6�   $��X��6�   $ Delete��6�   6�   �� 5?   2   $��ButtonAddIllustration��69   -   5        8�� $��1��5?   �   $��1��6�   $��+��6�   $ Add illustration��6�   6�   �� 5@   2   $��ButtonRename��69   8�� $��2��6x   $��1��6�   $��2��6�   $��0, 20, 0, 20q�6�   $��/��6�   $ Rename��6�   5A   /   5B   +   5D   #   5F      5G      5I      5J      5K      .��5L      � .+�5M   
   �� $
��Auto=�6   .��5N      � -   5        $��	Container��5N      ���	#FFECEBE76)   5O      5P      5Q      