   M S B A M L   `   `   `  ����I  EServisRacunara, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ServisRacunaraServisRacunara  5   	        ServisRacunara.TraziRezDeo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ServisRacunara     5   	     � Title$  TRAZI REZERVNI DEO��5   	   $��280.642��6$   $��484.357��65    � 
ResizeMode$ NoResize=�6E   ���	#FF8B8B8B.��5	      � $��0,0,0,10q�6   .+�5
   
   �� -   5         ��Name$ groupBox��5
      $��Izaberi:��6%   $
��Left=�67   $��50��6R   $��	10,10,0,0q�6^   $	��Top=�6q   $	��449��6�   .��5      � $��0,0,-2,0q�6   .+�5      �� -   5         ��Name$ label��5      $��Marka:��6'   $
��Left=�68   $	��Top=�6S   $
��Bold"�6k   �� 5      -   5        $ label1��5      $��Vrsta:��6(   $
��Left=�69   $��	162,3,0,0q�6T   $	��Top=�6g   $
��Bold"�6   �� 5      -   5         ��Name$ cb_marka��5      $
��Left=�6-   $��51,4,0,0q�6H   $	��Top=�6Z   $��97��6r   .@�5      �� .��6#   Intel6*   �� 5      .��6#   Amd6(   �� 5      .��6#   Msi6(   �� 5      .��6#   
Kingston6-   �� 5      .��6#   Asus6)   5      �� 5      -   5        $ cb_vrsta��5      $
��Left=�6-   $��	206,4,0,0q�6H   $	��Top=�6[   $��97��6s   .@�5      �� .��6#   
procesor6-   �� 5      .��6#   	maticna6,   �� 5      .��6#   
graficka6-   �� 5      .��6#   
memorija6-   5      �� 5      -   5         ��Name$ 	btn_trazi��5      $��Trazi��6,   $
��Left=�6<   $��	356,3,0,2q�6W   $��73��6j   $
��Bold"�6�   5      5      �� 5   
   -   5         ��Name$ listView��5      $
��Left=�6%   $	��150��6@   $��	10,84,0,0q�6M   $	��Top=�6`   $	��449��6x    �� View 5       �� 5!      .P�5"      �� $��Model��6%    �� Width$	 100��5$   	   	 �� DisplayMemberBinding	 5#   	   �� *Model+5$   	   �� 5%      $��Kolicina��6%   $	 100��5'   	   	 5&   	   �� *
Kolicina+5'   	   �� 5(      $
��Cena��6%   $	 100��5*   	   	 5)   	   �� *Cena+5*   	   5,      5.      50      51      