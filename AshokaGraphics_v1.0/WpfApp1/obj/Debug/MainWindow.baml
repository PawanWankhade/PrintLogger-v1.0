   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       AshokaGraphics.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5        $��ParentWindow��5	   F     � Title$  Print Logger v1.0��5   	   $	��600��6#   $	��700��60   ���	#FF480657 � WindowStartupLocation$ CenterScreen=�5	   !   .��5
      �  � RowDefinitions 5   
   �� 5      $��5* �6   �� 5      $	��40* �6   �� 5      $��5* �6   �� 5      $	��12* �6   �� 5      $��5* �6   �� 5      $
��200* �6   �� 5      $��5* �6   �� 5      $	��10* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��200* �6   �� 5      $	��10* �6   �� 5      $	��45* �6   �� 5      $��7* �6   �� 5      $	��45* �6   �� 5      $
��170* �6   �� 5      $	��45* �6   �� 5      $	��20* �6   .+�5"   
   �� $��images\logo2.png��6   $��1��6*   $��1��67   6I   �� 5#   
   -   5        $��searchTxtBox��5#      $��3��6&   $��15(�63   $��1��6A   $��Center=�6R   $��26��6m   �� 5$   
   -   5        $��3��5$      $��3��6   $��Search��6.   ���	#FF27AE615%      �� 5&   
   -   5        $��3��5&      $��5��6   $��Clear��6.   ���	#FF36BCDC6R   �� 5'   
   -   5        $��3��5'      $��7��6   $��Refresh��6.   ���	#FFE8A33E6W   &   System.Windows.Controls.DataGrid  5(   
   -   5        $��	DataGrid1��5(      $��5��6$   $��1��61   $��7��6A      ColumnHeaderHeight$ 40Q�6U      AutoGenerateColumns . 5)      �� 5*   
   -   5        $��	lblStatus��5*      $��3��6!   $��1��6.   $��20(�6>   ���	#FFC9F30A6L   �� 5+   
   -   5         ��Name$ 
textblock1��5+      $��1��6(   $��7��68   $��8��6E   $/��)Copyright © 2020-21 All rights reserved.��6Y   ���	#FFB2ADAD6�   5,      5.      