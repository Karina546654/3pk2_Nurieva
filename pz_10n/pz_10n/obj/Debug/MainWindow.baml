   M S B A M L   `   `   `  ����A  =pz_10n, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:pz_10npz_10n  5   	       pz_10n.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:pz_10n     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� .+�5
   
   �� $	��Top=�6   .+�5      o� 
��� ���$��20��6'   $��20��66   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ Button_open��5   -   $
��open��6   6^   m� 5      -   5        $ 
Button_new��5   ,   $	��new��6   6[   m� 5      -   5        $ Button_save��5   -   $
��save��6   5   (   m� 5      -   5        $ Button_delete��5   /   $��delete��6   6F   5      m� 5      $��Sample��6   .@�5      m� -   5        $ Create��5   /   $��Create��6   6V   m� 5      -   5        $
 Load��5   -   $
��Load��6   6P   5      m� 5      $��About��6   .@�5      m� -   5        $��About program��5      6N   m� 5      -   5        $��About autors��5      6L   5      m� 5      -	   5        $	��IMG��5      5      5      5      � 5!   
   $	��Top=�6   $��20��6)   
��� ���.+�5"      �� -
   5         ��Name$ Button_Delet��5"      .��5#      �� $��Icons/trash.png��6   63   5$      �� 5&      -   5        $ Button_bold��5&      .��5'      �� $��Icons/bold.png��6   62   5(      �� 5*      -   5        $ Button_kursiv��5*      .��5+      �� $��Icons/kursiv.png��6   64   5,      �� 5.      -   5        $ button_podcherknut��5.      .��5/      �� $(��"Icons/подчеркнутый.png��6    J� RenderTransformOrigin$ 14.614,0.962&�68   6_   50      51      �� 56   
   $��Bottom=�6   $��20��6,   $��1��68   
��� �����57      �� 58      .R�59      �  � ColumnDefinitions 5:      �� 5;      $��* �6/   6;   �� 5<      $
��auto �6/   6>   5>      5?      .@�5A      �� -   5         ��Name$ cursorPosition��5A   &   $��10(�6   6@   �� 5B      $��1��6   .��5C      �� -   5        $ DataTime��5C   *   $��10(�6   6>   5D      5E      �� 5G   
   -   5        $��listik��5G   4   $	��100��6   $
��Left=�6   
��� ���5H      �� 5I   
   -   5         ��Name$ 	txtEditor��5I       �� AcceptsReturn .  �� 	IsEnabled . 	 � Language$	 ru-ru�6{   
 �� 
AcceptsTab
 .  �� TextWrapping$
 Wrap=�6�   6�   5J      5K      