   M S B A M L   `   `   `  ����E  AFinal_Linq, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Final_Linq
Final_Linq  5   	       Final_Linq.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Final_Linq     5   	     � Title$  Menú��5   	   $
��1000��6   $
��2000��6$    � WindowState$ 	Maximized=�5	   	    � Icon$ /Imágenes/balon.png��5
   	    � 	Resources 5      ��%    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   ��    borderCabecera#��[  6   $��0��69   $��0��6I   $��2��6V   6l   �� 5   
     textoCabecera#��[ 6   $��Center=�6;   $��Fútbol-Manía��6X   $��Center=�6l   $��2��6�   6�   �� 5   
   $
��Left=�6   $��	0,-14,0,0q�6+   $��/Imágenes/balon.png��6>   $	��100��6[   �� 5    
   $��1��6   $��2��6"   .+�5!      �� $��/Imágenes/fondo.jpg��6   63   5"      �� 5$   
    �� Orientation$ Vertical=�6   $��1��6,   $��2��69   .+�5%      �� $ 
Horizontal=�6   $��170,200,170,0q�62   $��Center=�6I   .+�5&      �� -   5        $	��120��5&      $	��400��6&   $��	0,0,100,0q�62   ��5'      �� 5(      $ 
Horizontal=�6%   $	��400��6>   .+�5)      �� $��/Imágenes/buscar.png��6$   $��-50,-5,-23,0q�6B   $	��208��6X   $	��157��6d   6s   �� 5*      $��Center=�6$   .��6?   
Buscador6I   5+      5-      �� 5.      -   5        $	��120��5.      $	��400��6&   ��5/      �� 50      $ 
Horizontal=�6%   $	��400��6>   .+�51      �� $��/Imágenes/insertar.png��6$   $��-15,0,-50,0q�6D   6[   �� 52      $��Center=�6$   .��6?   
Insertar6I   53      55      56      �� 57      $ 
Horizontal=�6   $��170,180,170,0q�62   $��Center=�6I   .+�58      �� -   5        $	��120��58      $	��400��6&   $��	0,0,100,0q�62   ��59      �� 5:      $ 
Horizontal=�6%   $	��400��6>   .+�5;      �� $��/Imágenes/borrar.png��6$   $��-50,3,-40,0q�6B   $	��211��6W   $	��230��6d   6r   �� 5<      $��Center=�6$   .��6?   Borrar6G   5=      5?      �� 5@      -   5        $	��120��5@      $	��400��6&   ��5A      �� 5B      $ 
Horizontal=�6%   $	��400��6>   .+�5C      �� $��/Imágenes/actualizar.png��6$   $��-115,5,-120,0q�6F   $	��360��6]   $	��261��6i   6x   �� 5D      $��Center=�6$   .��6?   
Actualizar6K   5E      5G      5H      5I      5K      5L      