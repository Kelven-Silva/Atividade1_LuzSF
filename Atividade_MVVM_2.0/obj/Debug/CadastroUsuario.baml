   M S B A M L   `   `   `  ����M  IAtividade_MVVM_2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Atividade_MVVM_2._0Atividade_MVVM_2._0  5   	   )    #Atividade_MVVM_2._0.CadastroUsuario   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Atividade_MVVM_2._0     5   	   -   5        $��janelaUsuario��5   :     � Title$  CadastroUsuario��6	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ 	textBlock��5
      $
��Left=�6'   $��	35,17,0,0q�6B   $
��Wrap=�6U   $��Nome:��6i   $	��Top=�6v   $��16(�6�   �� 5   
   -   5         ��Name$ textBoxNome��5      $
��Left=�6k   $��	35,43,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��218��6�   $��26��6�   ��6'   �� *Usuario.Nome+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��
263,17,0,0q�6C   $
��Wrap=�6W   $
��CPF:��6k   $	��Top=�6w   $��16(�6�   �� 5   
   -   5        $ 
textBoxCPF��5      $
��Left=�6h   $��
263,43,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��178��6�   $��26��6�   ��6&   �� *Usuario.Cpf+$ PropertyChanged=�6�   �� 5   
   -   5        $ 
textBlock2��5      $
��Left=�6(   $��
459,17,0,0q�6C   $
��Wrap=�6W   $��	Endereço��6k   $	��Top=�6{   $��16(�6�   �� 5   
   -   5        $ textBoxEndereco��5      $
��Left=�6r   $��
459,43,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   $��26��6�   ��6+   �� *Usuario.Endereco+$ PropertyChanged=�6�   �� 5   
   -   5        $ 
textBlock3��5      $
��Left=�6(   $��
681,17,0,0q�6C   $
��Wrap=�6W   $	��N°��6k   $	��Top=�6u   $��16(�6�   �� 5   
   -	   5        $ textBoxNumeroRes��5      $
��Left=�6t   $��
681,43,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��94��6�   $��26��6�   $��3��6�   ��6,   �� *Usuario.NumeroRes+$ PropertyChanged=�6�   �� 5   
   -
   5        $ 
textBlock4��5      $
��Left=�6(   $��	35,86,0,0q�6C   $
��Wrap=�6V   $��Cidade��6j   $	��Top=�6x   $��16(�6�   $��Normal"�6�   �� 5   
   -   5        $ textBoxCidade��5      $
��Left=�6n   $��
35,112,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��178��6�   $��24��6�   ��6)   �� *Usuario.Cidade+$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ buttonSalvar��5      $��Salvar��6'    �� 	IsDefault . $��Center=�6�   $��Center=�6�   $��61��6�   $	��120��6�   $��16(�6�   $
��Bold"�6  ���	#FF30B91D��68   �� *SalvarCommand+��6Z   ��  �� ElementName$ janelaUsuario��6  5      5      