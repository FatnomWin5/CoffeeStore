   M S B A M L   `   `   `  ����L  HIndividualProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:IndividualProjectIndividualProject  5   	   "    IndividualProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:IndividualProject     5   	     � Title$!  Кофейная лавка��5   	   $	��720��6    $
��1280��6-    � 
ResizeMode$ NoResize=�6:   .��5	      � -   5         �Name$ Picture��5	      ���#6b3925.+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��CoffeeDataGrid��5
      $
��Left=�6)   $	��280��6D   $��
30,168,0,0q�6Q   $	��Top=�6e   $	��502��6}      
IsReadOnly .    CanUserAddRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 262 6�      CanUserResizeRows .     CanUserSortColumns .     CanUserResizeColumns .  	   CanUserReorderColumns	 .  6  �� 5   
   -   5        $��
YourChoice��5      $	��280��6%   $��744,168,28,0q�62   $	��Top=�6H   �� 5   
   $��Ваш выбор:��6   
�������$
��Left=�68   $��744,113,0,0q�6S   $	��Top=�6h   $��50��6�   $	��200��6�   $��30(�6�   �� 5   
   -   5        $!��Оформить заказ��5      $
��Left=�6*   $	��Top=�6E   $	��200��6]   $��1046,476,0,0q�6i   $��50��6�   $��20(�6�   �� 5   
   $��Виды кофе:��6   
�������$
��Left=�68   $	��Top=�6S   $��
30,113,0,0q�6k   $��50��6   $	��200��6�   $��30(�6�   �� 5   
   -   5        $'��!Посмотреть состав��5      $
��Left=�6-   $	��Top=�6H   $	��200��6`   $��
30,476,0,0q�6l   $��50��6�   $��20(�6�   �� 5   
   -   5        $$��Убрать из заказа��5      $
��Left=�6,   $	��Top=�6G   $	��200��6_   $��744,476,0,0q�6k   $��50��6�   $��20(�6�   �� 5   
   -   5        $$��Добавить в заказ��5      $
��Left=�6,   $	��Top=�6G   $	��200��6_   $��332,476,0,0q�6k   $��50��6�   $��20(�6�   �� 5   
   $!��Кофейная лавка��6   ���#e38f12$
��Left=�6>   $	��Top=�6Y   $��	50,10,0,0q�6q   $
��1173��6�   $��98��6�   $��63(�6�   $��Center=�6�   �� 5   
   -   5        $-��'Забронировать столик��5      $
��Left=�60   $	��Top=�6K   $	��502��6c   $��
30,562,0,0q�6o   $��50��6�   $��20(�6�   5      5      