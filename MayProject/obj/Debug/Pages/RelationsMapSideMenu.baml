   M S B A M L   `   `   `  ����E  AMayProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MayProject.PagesMayProject.Pages  5      'clr-namespace:MayProject
MayProject  5      +    %MayProject.Pages.RelationsMapSideMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:MayProject.Pages     5      )projclr-namespace:MayProject     5      ���	#FF213869  � 	Resources  5
      $   MayProject.BorderClipConverter   BorderClipConverter  RoundCorners �� Property �� Value �� 
TargetType ��Name �� CornerRadius J� Clip `� 	Converter �� Path	 �� RelativeSource��%*  &	        &	      7     5      6   �� 5      .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ ButtonBorder��6!   $��0q�67   $	 180��6K   
�������$��60��6t   $��60��6�   ._�5      �� $��Center=�6/   $��Center=�6J    5      `� 5   "   8   .1�5   &   �� $ ActualWidth�6.   	 5      �� *Self+�� 5   &   $ ActualHeight�6.   	 5      �� *Self+�� 5   &   $ CornerRadius�6.   	 5      �� *Self+5   #   5      5      5      5       5!      .��5"      � 
 � ColumnDefinitions
 5#   
   �� 5$      �� 5%       � RowDefinitions 5'   
   �� 5(      $��50 �6   �� 5)      $
��Auto �6   �� 5*      $
��Auto �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   .+�5.   
   �� -   5        $��RelationsMapSwitch��5.      
�������$��	Relations��6A   $��20(�6U   $��0��6c   $��0��6p   �� 5/   
   -   5        $��EventsMapSwitch��5/      
�������$��Events��6:   $��20(�6K   $��0��6Y   $��1��6f   �� 51   
   $��
Characters��6   $��0��6&   $��2��66   $��1��6J   $��25(�6W   $��10q�6e   $��Center=�6q   
�������6�   A� 52   
   -   5        $��SideMenu_Characters��52       A� Columns$ 2��61   $��2��6=   $��0��6J   $��2��6Z   �� 54   
   $��	Locations��6   $��0��6%   $��2��65   $��3��6I   $��20(�6V   $��10q�6d   $��Center=�6p   
�������6�   A� 55   
   -   5        $��SideMenu_Locations��55      $ 2��60   $��4��6<   $��0��6I   $��2��6Y   56      57      