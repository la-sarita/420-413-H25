   M S B A M L   `   `   `  ����J  FCustomersApp.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CustomersApp.UI.ViewCustomersApp.UI.View  5   	   (    "CustomersApp.UI.View.CustomersView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:CustomersApp.UI.View     5   	     � Title$  CustomersView��5   	   $	��450��6   $	��800��6,   .��5	      �� .+�5
   
   �� ��6   �� *	Customers+ �� SelectedItem 65   �� *SelectedCustomer+ �� View 5      �� 5      .P�5      �� $��
First Name��6P    �� DisplayMemberBinding 6%   �� *	FirstName+6P   �� 5      $��	Last Name��6O    6%   �� *
LastName+6O   5      5      �� 5   
   $��
First Name��6   �� 5   
   ��6   �� *SelectedCustomer.FirstName+�� 5   
   $��	Last Name��6   �� 5   
   ��6   �� *SelectedCustomer.LastName+�� 5   
   $��Is Developer��6   �� 5   
    d� 	IsChecked 6   �� *SelectedCustomer.IsDeveloper+5      5      