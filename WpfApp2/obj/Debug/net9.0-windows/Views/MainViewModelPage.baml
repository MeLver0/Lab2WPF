   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.ViewsWpfApp2.Views  5      7 clr-namespace:WpfApp2.ViewModelsWpfApp2.ViewModels  5      %    WpfApp2.Views.MainViewModelPage   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp2.Views     5      7
viewModels clr-namespace:WpfApp2.ViewModels     5        N� Title$  MainViewModel��5	      $	��600��6   $
��1000��6*    � DataContext 5
      &    WpfApp2.ViewModels.MainViewModel  5   
   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $	��200��5      $��10q�6#   ��5      �� *
Interfaces+ �� SelectedItem 5      �� *SelectedInterface+��5      �� 5      .R�5      �� .+�5      �� $
��Bold"�6>   ��6(   �� *Name+6>   �� 5       ��6(   �� *	IPAddress+�� 5!      ��6(   �� *Status+5"      5#      5%      �� 5(      $��1��6   $��10q�6&   .+�5)      �� $��Interface Details��6   $
��Bold"�65   $��0,0,0,10q�6G   �� 5,      $��IP Address:��6   $
��Bold"�6/   �� 5-      $��0, 0, 0, 10q�6I   ��6   �� *SelectedInterface.IPAddress+6I   �� 5/      $��SubnetMask:��6   $
��Bold"�6/   �� 50      $��0, 0, 0, 10q�6J   ��6   �� *SelectedInterface.SubnetMask+6J   �� 52      $��MAC Address:��6   $
��Bold"�60   �� 53      $��0, 0, 0, 10q�6J   ��6   �� *SelectedInterface.MacAddress+6J   �� 55      $��Status:��6   $
��Bold"�6+   �� 56      $��0, 0, 0, 10q�6F   ��6   �� *SelectedInterface.Status+6F   �� 58      $��Speed:��6   $
��Bold"�6*   �� 59      $��0, 0, 0, 10q�6E   ��6   �� *SelectedInterface.Speed+6E   �� 5;      $��Interface Type:��6   $
��Bold"�63   �� 5<      $��0, 0, 0, 10q�6M   ��6   �� *!SelectedInterface.InterfaceType+6M   5=      �� 5?      -   5        $��2��5?      $��Go to URL Analyzer��6"   $��Right=�5@      $��Bottom=�5A      $��10q�5B      $	��150��5C      5D      5F      5H      5I      