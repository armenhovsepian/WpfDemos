   M S B A M L   `   `   `  ����M  IWpfProgressBarDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfProgressBarDemoWpfProgressBarDemo  5   	   #    WpfProgressBarDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfProgressBarDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   ]� $��10q�6   .+�5      ]� $	��Top=�6   .+�5      �� -   5        $!��btnDoSynchronousCalculation��5      $
��Left=�6f   $
��Left=�6|   .��6�   Synchronous (same thread)6�   �� 5      -   5        $"��btnDoAsynchronousCalculation��5      $��Right=�6h   $��Right=�6   .��6�   Asynchronous (worker thread)6�   5      � 5      -   5        $��pbCalculationProgress��5   >   $��Bottom=�6   $��18��62   6>   �� 5      -   5        $��	lbResults��5      $
��0,10q�6'   5      5      5      