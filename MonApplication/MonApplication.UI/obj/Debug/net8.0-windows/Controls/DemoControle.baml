   M S B A M L   `   `   `  ����B  >Demo.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Demo.UI.ControlsDemo.UI.Controls  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   #    Demo.UI.Controls.DemoControle   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Demo.UI.Controls     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   $	��450��5	   	   $	��800��6   .��5      �   � ColumnDefinitions  5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      .+�5   
   �� .+�5      �� -   5        $��comboBox��5      $	��200��5      $��30��5      $��10q�5       �� SelectedItem 5      �� *SelectedOption+.@�5      �� $��Option 1��6   �� 5      $��Option 2��6   �� 5      $��Option 3��6   5      �� 5       -   5        $��listBox��5       $	��200��6%   $	��150��61   $��10q�6>   .@�5!      �� $��Item 1��6    �� 
IsSelected$
 True��6/   �� 5"      $��Item 2��6   �� 5#      $��Item 3��6   5$      �� 5&      -   5        $��slider��5&       � Minimum$ 0Q�6#    � Maximum$	 100Q�6/    � Value$ 50Q�6=   $	��200��6H   $��30��6T   $��10q�6`   �� 5'      -   5         ��Name$ sliderValue��5'      ��6-   ��  �� ElementName$ slider��	 �� Path$	 Value�
 �� UpdateSourceTrigger$
 PropertyChanged=�5(      �� 5*   
   $��1��6   .+�5,      �� -   5        $��checkBox��5,      $��I agree��6'   $	��200��69   $��30��6E   $��10q�6Q   �� 5.      -   5         ��Name$ choicesStackPanel��5.      $
��20,0q�64   .+�5/      	� $��Choice 1��6    	� 	GroupName$ Options��61   	� 50      $��Choice 2��6   $ Options��61   	� 51      $��Choice 3��6   $ Options��61    d� 	IsChecked$
 TrueY�6E   52      �� 54      .+�55      ��  �� Orientation$ 
Horizontal=�6   .+�56      �� $��Selected option :��6   �� 57      ��6   �� $ comboBox��$	 SelectedItem.Content�58      �� 5:      $ 
Horizontal=�6   .+�5;      �� $��Selected item :��6   �� 5<      ��6   �� $ listBox��$	 SelectedItem.Content�5=      �� 5?      $ 
Horizontal=�6   .+�5@      �� $��Agree :��6   �� 5A      -   5         ��Name$ chechedAgree��5A      ��62   �� $ checkBox��$	 	IsChecked�5B      �� 5D      $ 
Horizontal=�6   .+�5E      �� $��Selected date :��6   �� 5F      ��6   �� $ 
datePicker��$	 SelectedDate� �� StringFormat$ {0:dd.MM.yyyy}��5G      �� 5I      $ 
Horizontal=�6   .+�5J      �� $�� :��6   5K      5L      �� 5N      -   5        $��60��5O      
��� � �
�������.��5Q   (   Show � ToolTip 5S      _� 5T      $��Collect data��6   5V      5W      �� 5X   
   $��2��6   .+�5Y      �� -	   5         ��Name$ image��5Y      $	��120��6#   $��70��6/   $��logo.png��6;   $��5q�6M   (  "System.Windows.Controls.DatePicker  5[      -
   5        $��
datePicker��5[      $	��200��5\      $��30��5]      $��10q�5^      
 �� Now   DisplayDate# Z 5_         SelectedDate# Z 5`      5a      �� 5b   
   $��1��6   $��20q�6"   .+�5c      � -   5        $��progressBar��5c      $	��200��5d      $��30��5e      $��10q�5f      $ 0Q�5g      $	 100Q�5h       5i      �� $ progressVal��$
	 Text�$
 PropertyChanged=��� 5j      -   5         ��Name$ progressVal��5j      $��50��6+   5k      �� 5m   
   $��1��6   $��1��6"   $��10q�62   $	��100��6>   .+�5n      �� .��6   Démo button6%   �� 5o      -   5        $
��btn1��5o      
�������
���   �$��1q�5r       �� 	ClickMode$ Hover=�5t      .��6+   
ClickMe15v      �� 5x      -   5        $
��btn2��5x      
����ح�
���   �$��1q�5{      $ Press=�5}      .��6+   
ClickMe25      �� 5�      -   5        $
��btn3��5�      $ Release=�5�      .��6-   Reset5�      5�      �� 5�   
   $��1��6   $��2��6"   .+�5�      ]� $��1��6   .+�5�      �� $	��100��6   $	��Top=�6$   .��6:   Démo button6G   �� 5�      -   5        $	��100��5�      $	��Top=�5�       �� Delay$	 500��5�       �� Interval$	 100��5�      .��5�   $   
Increase5�      �� 5�      -   5        $��	valueText��5�      $	��100��5�      $	��Top=�5�       �� TextAlignment$ Center=�5�      $��16(�5�      05�      �� 5�      -   5        $	��100��5�      $	��Top=�5�      $	 500��5�      $	 100��5�      .��5�   *   
Decrease5�      5�      5�      5�      5�      