   M S B A M L   `   `   `  ����G  CMovieManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieManagerMovieManager  5          MovieManager.Header   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MovieManager     5      
�������  � 	Resources  5
         btnHeaderStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value��%  &	        �� 5   
   " ��6'   .�5      ��  � ��
 ���� 6+   �� 5       � ��
 �   �6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   
������ $ 0, 0, 10, 10��6e   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �#7BDA3763   �� 5       � ��
 �����63   �� 5       �@�Cursor$
 Hand��6/   5      5      5      .��5       � -   5        	 �Name$	 UserControlHeaderGrid��5       .+�5!   
   �� -   5        
 ��Name$
 btnLogin��5!      $��0,0,30,5q�6#   $��Đăng nhập��65   $��15(�6I   #��[  6W   $��Right=�6�   $	��100��6�   �� 5"   
   -   5        $
 btnFilms��5"      $��78,0,0,5q�6#   $
��Phim��65   $��15(�6D   #��[  6R   $
��Left=�6�   $	��100��6�   �� 5#   
   -   5        $
 
btnCinemas��5#      $��	225,0,0,5q�6%   $��Rạp chiếu phim��68   $��15(�6Q   #��[  6_   $
��Left=�6�   $	��126��6�   �� 5$   
   -   5        $
 btnMovieShowtimes��5$      $��	405,0,0,5q�6,   $��Lịch chiếu��6?   $��15(�6T   #��[  6b   $
��Left=�6�   $	��126��6�   5'      5(      