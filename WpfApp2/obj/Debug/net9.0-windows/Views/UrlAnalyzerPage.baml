   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp2.ViewsWpfApp2.Views  5      7 clr-namespace:WpfApp2.ViewModelsWpfApp2.ViewModels  5      #    WpfApp2.Views.UrlAnalyzerPage   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp2.Views     5      7
viewModels clr-namespace:WpfApp2.ViewModels     5        N� Title$  UrlAnalyzerPage��5	      $	��600��6   $
��1000��6,    � DataContext 5      -   'WpfApp2.ViewModels.UrlAnalyzerViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��10q�6;   .+�5      �� $	��600��6P   $��25��6\   $	��Top=�6h   ��6   �� *Url+ �� UpdateSourceTrigger$ PropertyChanged=�6h   �� 5       $��Analyze��6   $
��Left=�6J   $	��Top=�6e   $��10q�6}   $	��100��6�   ��6'   �� *AnalyzeCommand+6�   5!      �� 5$   
   $ Vertical=�6   $��1��6,   $��
10 10 10 0q�69   .+�5%      �� $��Scheme:��6   �� 5&      ��6   �� *Scheme+�� 5'      $��Host:��6   �� 5(      ��6   �� *Host+�� 5)      $��Port:��6   �� 5*      ��6   �� *Port+�� 5+      $��Path:��6   �� 5,      ��6   �� *Path+�� 5-      $��Query:��6   �� 5.      ��6   �� *Query+�� 5/      $��	Fragment:��6   �� 50      ��6   �� *
Fragment+�� 51      $��Ping Result:��6   �� 52      ��6   �� *
PingResult+�� 53      $��DNS Information:��6   �� 54      ��6   �� *	DnsInfo+�� 55      $��Address Type:��6   �� 56      ��6   �� *AddressType+57      �� 5:   
   $��2��65   $��
10 5 10 10q�6B   $	��180��6V   ��6   �� *
UrlHistory+��5;      �� 5<      .R�5=      �� ��6    �� 5>      5@      �� 5C   
   -   5        $��Back to Main ViewModel��5C      $
��Left=�5D      $��Bottom=�5E      $��10q�5F      $	��150��5G      $��3��5H      5I      5J      5K      