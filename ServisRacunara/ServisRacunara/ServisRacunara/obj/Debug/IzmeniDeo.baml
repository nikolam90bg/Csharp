   M S B A M L   `   `   `  ����I  EServisRacunara, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ServisRacunaraServisRacunara  5   	       ServisRacunara.IzmeniDeo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ServisRacunara     5   	     � Title$  
IZMENI DEO��5   	   $	��353��6   $	��225��6)    � 
ResizeMode$ NoResize=�65   ���	#FF8B8B8B.��5	      � .+�5
   
   �� -   5         ��Name$ groupBox��5
      $��Ubaci bar kod:��6%   $
��Left=�6=   $��63��6X   $��	10,10,0,0q�6d   $	��Top=�6w   $	��192��6�   .��5      � .+�5      �� -   5         ��Name$ 	tb_barkod��5      $
��Left=�6-   $��23��6H    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $��86��6�   $��0,10,0,0q�6�   �� 5      -   5         ��Name$ 	btn_trazi��5      $��Trazi��6,   $
��Left=�6<   $��	106,9,0,0q�6W   $	��Top=�6j   $��69��6�   $��24��6�   $
��Bold"�6�   5      5      �� 5   
   -   5        $ 	groupBox1��5      $��Rezervni deo:��6&   $
��Left=�6=   $	��195��6X   $��	10,78,0,0q�6e   $	��Top=�6x   $	��192��6�   .��5      � $��0,0,-2,0q�6   .+�5      �� -   5         ��Name$ label��5      $��Marka:��6'   $
��Left=�68   $��10,5,0,0q�6S   $	��Top=�6e   $
��Bold"�6}   �� 5      -   5        $ 
label_Copy��5      $��Vrsta:��6,   $
��Left=�6=   $��	10,36,0,0q�6X   $	��Top=�6k   $
��Bold"�6�   �� 5      -   5        $ label_Copy1��5      $��	Kolicina:��6-   $
��Left=�6A   $��	10,98,0,0q�6\   $	��Top=�6o   $
��Bold"�6�   �� 5      -   5        $ label_Copy2��5      $��Cena:��6-   $
��Left=�6=   $��
10,124,0,0q�6X   $	��Top=�6l   $
��Bold"�6�   �� 5      -	   5        $ tb_cena��5      $
��Left=�6+   $��26��6F   $��
81,129,0,0q�6R   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $��91��6�   �� 5      -
   5         ��Name$ cb_vrsta��5      $
��Left=�6-   $��26��6H   $��	81,36,0,0q�6T   $	��Top=�6g   $��91��6   .@�5      �� .��6#   
procesor6-   �� 5      .��6#   	maticna6,   �� 5      .��6#   
graficka6-   �� 5      .��6#   
memorija6-   5      �� 5      -   5        $ cb_marka��5      $
��Left=�6-   $��26��6H   $��81,5,0,0q�6T   $	��Top=�6f   $��91��6~   .@�5      �� .��6#   Intel6*   �� 5      .��6#   Amd6(   �� 5       .��6#   Msi6(   �� 5!      .��6#   
Kingston6-   �� 5"      .��6#   Asus6)   5#      �� 5$      -   5        $ label_Copy3��5$      $��Model:��6-   $
��Left=�6>   $��	10,67,0,0q�6Y   $	��Top=�6l   $
��Bold"�6�   �� 5%      -   5        $ tb_model��5%      $
��Left=�6,   $��26��6G   $��	81,67,0,0q�6S   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $��91��6�   �� 5&      -   5        $ tb_kolicina��5&      $
��Left=�6/   $��26��6J   $��	81,98,0,0q�6V   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $��91��6�   5'      5(      �� 5)   
   -   5        $ btn_sacuvaj��5)      $��SACUVAJ��6&   $
��Left=�68   $��31��6S   $��
10,278,0,0q�6_   $	��Top=�6s   $	��192��6�   $
��Bold"�6�   5/      50      