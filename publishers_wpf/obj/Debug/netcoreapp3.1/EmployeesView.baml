   M S B A M L   `   `   `  ����  publishers_wpf"    publishers_wpf.EmployeesView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ btnZoekWerknemers��5      $��Zoek alle Werknemers��6,   $��0��6K   $��0��6X   $��2��5      $��5q�6%   60   �� 5   
   -   5         ��Name$ cmbJobs��5       �� DisplayMemberPath$ job_desc��6$   $��1��6A   $��0��6N   $��5q�6^   �� 5   
   -   5        $ btnZoekEmployeesViaJob��5      $��Zoek Werknemers via job��61   $��1��6S   $��1��6`   $��5q�6p   6{   �� 5"   
   -   5        $ cmbPublishers��5"      $ pub_name��6*   $��2��6G   $��0��6T   $��5q�6d   �� 5$   
   -   5        $ btnZoekWerknemersViaPubid��5$      $��Zoek Werknemers via pub��64   $��2��6V   $��1��6c   $��5q�6s   6~   �� 5'   
   -   5        $' !btnZoekWerknemersViaPubidEnJob_id��5'      $$��Zoek Werknemers via pub en job��6<   $��3��6e   $��0��6r   $��2��6�   $��5q�6�   6�   �� 5*   
   -   5         ��Name$ txtHireDate��5*      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Hire_date��6)    %  !MaterialDesignFloatingHintTextBox#��[  5+      $��Center=�5,      $��4��6.   $��0��6;   $��5q�6K   �� 5-   
   -   5        $" btnZoekWerknemersViaHireDate��5-      $��Zoek Werknemers��67   $��4��6Q   $��1��6^   $��5q�6n   6y   �� 50   
   -	   5        $ 	txtEmp_id��50      $ emp_id��6'   #��[  51      $��Center=�52      $��5��6.   $��0��6;   $��5q�6K   �� 53   
   -
   5        $ btnZoekWerknemerviaPK��53      $��Zoek Werknemer��60   $��5��6I   $��1��6V   $��5q�6f   6q   &   System.Windows.Controls.DataGrid  55   
   -   5          Name$ datagridEmployees��55         AutoGenerateColumns$
 True��60   $��0��6K   $��2��6X   $��7��6h   56      57      58      