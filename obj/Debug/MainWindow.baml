   M S B A M L   `   `   `  ����  
Cotizacion    Cotizacion.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Cotiza��5   	   $��584.316��6   $��1028.044��6)    � 
ResizeMode$ CanResizeWithGrip=�6:   .��5      � .+�5   
   �� -   5         ��Name$ TxtAnno��5      $
��Left=�6#   $��23��6>   $��
256,18,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $��Buscar Vehiculo��5      $
��Left=�6+   $��
403,20,0,0q�6F   $	��Top=�6Z   $��94��6r   6}   �� 5   
   -   5        $ 	TxtCodigo��5      $
��Left=�6%   $��22��6@   $
 Wrap=�6L   $	��Top=�6`   $	��120��6x    J� RenderTransformOrigin$ 
0.34,4.061&�6�   $��	77,18,0,0q�6�   �� 5	   
   $��Codigo��6   $
��Left=�6!   $��	24,14,0,0q�6<   $	��Top=�6O   �� 5
   
   $
��Año��6   $
��Left=�6   $��
219,15,0,0q�69   $	��Top=�6M   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgTabla��5      $
��Left=�6$   $��
24,153,0,0q�6?   $	��Top=�6S   $	��374��6k   $	��966��6x      AutoGenerateColumns .   �� SelectedIndex$ 0��6�      CanUserResizeRows .  	   
IsReadOnly	 . 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ��  �� Path$ Codigo�6U     5      $
 Año��6%    .  62   �� $
 Anno�6P     5      $
 Tipo��6%    .  63   �� $
 Tipo�6Q     5      $ Marca��6%    .  64   �� $ Marca�6S     5      $ Modelo��6%    .  65   �� $ Modelo�6U     5      $ Puertas��6%    .  66   �� $ Puertas�6W     5      $ 	Cilindros��6%    .  68   �� $ 	Cilindros�6[     5      $ Combustible��6%    .  6:   �� $ Combustible�6_     5      $ Transmision��6%    .  6:   �� $ Transmision�6_     5      $ Equipo��6%    .  65   �� $ Equipo�6U     5      $ Tasacion��6%    .  67   �� $ Tasacion�6Y     5      $ Permiso��6%    .  66   �� $ Permiso�6W   5      �� 5   
   -   5         ��Name$ CmbTipo��5      $
��Left=�6$   $��
24,109,0,0q�6?   $	��Top=�6S   $	��120��6k   6w   �� 5   
   -   5        $ 	CmbMarcas��5      $
��Left=�6&   $��149,109,0,0q�6A   $	��Top=�6V   $	��120��6n   6z   �� 5   
   -   5        $ CmbAnno��5      $
��Left=�6$   $��274,109,0,0q�6?   $	��Top=�6T   $	��120��6l   6x   �� 5   
   -   5        $ CmbCilindros��5      $
��Left=�6)   $��399,109,0,0q�6D   $	��Top=�6Y   $	��120��6q   6}   �� 5   
   -	   5        $ 
CmbPuertas��5      $
��Left=�6'   $��524,109,0,0q�6B   $	��Top=�6W   $	��120��6o   6{   �� 5    
   -
   5        $ CmbTransmision��5       $
��Left=�6+   $��649,109,0,0q�6F   $	��Top=�6[   $	��120��6s   6   �� 5!   
   $
��Tipo��6   $
��Left=�6   $��	24,78,0,0q�6:   $	��Top=�6M   $	��120��6e   �� 5"   
   $��Marca��6   $
��Left=�6    $��
149,78,0,0q�6;   $	��Top=�6O   $	��120��6g   �� 5#   
   $
��Año��6   $
��Left=�6   $��
274,78,0,0q�69   $	��Top=�6M   $	��120��6e   �� 5$   
   $��
Cilindrada��6   $
��Left=�6%   $��
399,78,0,0q�6@   $	��Top=�6T   $	��120��6l   �� 5%   
   $��Puertas��6   $
��Left=�6"   $��
524,78,0,0q�6=   $	��Top=�6Q   $	��120��6i   �� 5&   
   $��Transmision��6   $
��Left=�6&   $��
649,78,0,0q�6A   $	��Top=�6U   $	��120��6m   �� 5'   
   -   5         ��Name$ 
BtnLimpiar��5'      $��Limpiar��6%   $
��Left=�67   $��
830,20,0,0q�6R   $	��Top=�6f   $	��160��6~   $	��111��6�   6�   5)      5*      