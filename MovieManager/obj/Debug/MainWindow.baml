   M S B A M L   `   `   `  ����G  CMovieManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MovieManagerMovieManager  5   	   ?$clr-namespace:MovieManager.SearchBoxMovieManager.SearchBox  5   	       MovieManager.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ,localclr-namespace:MovieManager     5   	   :	SearchBox$clr-namespace:MovieManager.SearchBox     5   	   -   5          �Name$  
mainWindow��5   	   
������� � Icon$( "Resources/Background-Icon/logo.png��5   	    � Title$ 
MainWindow��5	   	   $	��715��6   $	��953��6)    � WindowStartupLocation$ CenterScreen=�65   .��5
      � -   5         �Name$ RootGrid��5
      .+�5   
   �� -   5         ��Name$ scrollviewerMain��5      $
��Auto=�5      $
��Auto=�5      .��5      � $
��1349��6   .+�5         MovieManager.Header  -   5          Name$ ucHeader��5      $	��Top=�5      $��50��5      $��0q�6+   ��.   J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6+   	   ShadowDepth$	 3Q�6;   5      � 5      -   5        
 �Name$
 
pnShowList��5      
������ $��
0,130,0,10q�5      $
��1000��5      &    MovieManager.SearchBox.SearchBox  5      -   5          Name$ ucSearchBox��5   &   $��
0,10,160,0q�6;   $	��Top=�6O   $	��190��6g   $��Right=�6s   5      5      � 5   
   -   5        $ OverlayGrid��5      ���	#B2000000$y�	Collapsed=�5!      5#      5%      5&      