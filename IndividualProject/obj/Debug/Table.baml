   M S B A M L   `   `   `  ����L  HIndividualProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:IndividualProjectIndividualProject  5   	       IndividualProject.Table   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:IndividualProject     5   	     � Title$-  'Бронирование столика��5   	   $	��360��6&   $��524.5��63    � 
ResizeMode$ NoResize=�6A    � WindowStartupLocation$ CenterScreen=�6W   .��5	      � ���#6b3925.+�5
   
   �� -   5         ��Name$ TableSelection��5
      $
��Left=�6+   $��104,239,0,0q�6F   $	��Top=�6[   $	��120��6s   .@�5      �� 16   �� 5      26   �� 5      36   �� 5      46   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$
 Date��5      $
��Left=�6#   $��244,239,0,0q�6>   $	��Top=�6S   $��26��6k   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    � MappingMode$ RelativeToBoundingBox=�67    �� 
StartPoint$ 0.5,0&�6[   .��5      �  � Color$ 	#FFA3AEB9��6#   � 5      $ 	#FF8399A9��6#   � 5      $ 	#FF6B3925��6#   	 � Offset$	 1Q�65   � 5      $ 	#FF6B3925��6#   $	 0.703Q�65   � 5      $ 	#FF6B3925��6#   � 5      $ 	#FF6B3925��6#   $	 0.435Q�65   5      5      �� 5   
   $
��Left=�6   $	��197��6+   $	��Top=�68   $	��298��6P   $��
104,10,0,0q�6\   $��
tables.png��6p   �� 5   
   -   5        
 ��Name$
 
WarningOne��5      $��
Занят��6$   $
��Left=�64   $	��Top=�6O   $��
156,63,0,0q�6g   ���#FF0000$
��Bold"�6�   $y�Hidden=�6�   �� 5   
   -   5        $
 
WarningTwo��5      $��
Занят��6$   $
��Left=�64   $	��Top=�6O   $��
302,63,0,0q�6g   ���#FF0000$
��Bold"�6�   $y�Hidden=�6�   �� 5   
   -   5        $
 WarningThree��5      $��
Занят��6&   $
��Left=�66   $	��Top=�6Q   $��156,164,0,0q�6i   ���#FF0000$
��Bold"�6�   $y�Hidden=�6�   �� 5    
   -   5        $
 WarningFour��5       $��
Занят��6%   $
��Left=�65   $	��Top=�6P   $��302,164,0,0q�6h   ���#FF0000$
��Bold"�6�   $y�Hidden=�6�   �� 5!   
   -   5         ��Name$ TableReserve��5!      $ ��Забронировать��6'   $
��Left=�6?   $	��Top=�6Z   $	��291��6r   $��104,276,0,0q�6~   6�   5"      5#      