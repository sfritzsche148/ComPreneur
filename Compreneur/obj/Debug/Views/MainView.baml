   M S B A M L   `   `   `  ����E  ACompreneur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Compreneur.ViewsCompreneur.Views  5      X THelixToolkit.Wpf, Version=2.25.0.0, Culture=neutral, PublicKeyToken=52aa3500039caf0dM8clr-namespace:HelixToolkit.Wpf;assembly=HelixToolkit.WpfHelixToolkit.Wpf 5          Compreneur.Views.MainView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Compreneur.Views     5      Jhelix8clr-namespace:HelixToolkit.Wpf;assembly=HelixToolkit.Wpf     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $	��20* �6   �� 5      $	��80* �6   �� 5      $	��80* �6   �� 5      $	��80* �6   �� 5      $	��20* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��Unternehmensübersicht��6   $��20, 0, 20, 0q�5      $��0��5      $��1��5      �� 5   
   $��	Aufträge��6   $��20, 0, 20, 0q�5       $��0��5!      $��2��5"      �� 5#   
   $��Mitarbeiter��6   $��20, 0, 20, 0q�5$      $��0��5%      $��3��5&      �� 5(   
   $	��GB1��6   $��0, 40, 0, 20q�5)      $��1��5*      $��0��5+      �� 5,   
   $	��GB2��6   $��0, 20q�5-      $��2��5.      $��0��5/      �� 50   
   $	��GB3��6   $��0, 20q�51      $��3��52      $��0��53      &   HelixToolkit.Wpf.HelixViewport3D  55   
   $��1��6    $��3��56       $��2��57          ShowViewCube .     Children. 59      g� -   5        modelGB4�� g� Content 59   .   �� *MainBuildingModel.Model+5:      �� 5<   
   $	��ST1��6   $��0, 40, 0, 20q�5=      $��1��5>      $��4��5?      �� 5@   
   $	��ST2��6   $��0, 20q�5A      $��2��5B      $��4��5C      �� 5D   
   $	��ST3��6   $��0, 20q�5E      $��3��5F      $��4��5G      �� 5I   
   $��Abteilungen��6   $��20, 0, 20, 0q�5J      $��4��5K      $��1��5L      �� 5M   
   $��Sales��6   $��20, 0, 20, 0q�5N      $��4��5O      $��2��5P      �� 5Q   
   $��	Marketing��6   $��20, 0, 20, 0q�5R      $��4��5S      $��3��5T      5U      5V      