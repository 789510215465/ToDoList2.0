   M S B A M L   `   `   `  ����C  ?todoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:todoListtodoList  5   	       todoList.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:todoList     5   	   -   5          � Title$  
MainWindow��5   	   $	��500��6   $	��300��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   6*   �� 5      6   �� 5      $��30 �6   6*   .+�5   
   �� $��Center=�6   $
��10 0q�6/   2018/05/17 15 : 00 ~ 18 : 006\   � 5   
   $��1��6    5      �� 5      6"   �� 5      $��50 �6    6.   .+�5      �� -   5         ��Name$ TodoItemList��5      .+�5         todoList.TodoItem  6(   5      �� 5      -   5         ��Name$ AddBtn��5   )   $��1��6   .��6N   ADD6S   5      �� 5    
   $��2��6    �� Orientation$ 
Horizontal=�6"   .+�5!      � .+�5"      �� -   5         ��Name$ SaveBtn��5"   @   $	��150��6   $��50��6(   
�������5#      �� 5$      
�������$��Center=�6/   $��Center=�6J   Save6n   5%      �� 5'      $	��150��6   .��6%   Open6+   5(      5)      5*      