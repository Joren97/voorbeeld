   M S B A M L   `   `   `  ����  publishers_wpf    publishers_wpf.StoresView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ txtNaam��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Naam��6%    %  !MaterialDesignFloatingHintTextBox#��[  5      $��Center=�5      $��0��6.   $��0��6;   $��5q�6K   �� 5   
   -   5         ��Name$  btnZoekWinkelsViaStor_name��5      $��Zoek Winkels via name��65   $��0��6U   $��1��6b   $��5q�6r   6}   �� 5   
   -   5        $ txtState��5      $
 City��6&   #��[  5      $��Center=�5       $��1��6.   $��0��6;   $��5q�6K   �� 5!   
   -   5        $ btnZoekWinkelsViaState��5!      $��Zoek Winkels via state��61   $��1��6R   $��1��6_   $��5q�6o   6z   �� 5$   
   -   5        $" btnZoekWinkelsViaNaamEnState��5$      $$��Zoek Winkels via name en state��67   $��2��6`   $��0��6m   $��2��6}   $��5q�6�   6�   �� 5'   
   -   5        $ txtID��5'      $ ID��6#   #��[  5(      $��Center=�5)      $��3��6.   $��0��6;   $��5q�6K   �� 5*   
   -   5        $ btnZoekWinkelsViaPK��5*      $��Zoek Winkels��6.   $��3��6E   $��1��6R   $��5q�6b   6m   &   System.Windows.Controls.DataGrid  5,   
   -   5          Name$ datagridStores��5,         AutoGenerateColumns$
 True��6-   $��0��6H   $��2��6U   $��5��6e   5-      5.      5/      