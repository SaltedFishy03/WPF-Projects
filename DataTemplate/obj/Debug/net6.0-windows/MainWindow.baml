   M S B A M L   `   `   `  ????G  CDataTemplate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DataTemplateDataTemplate  5   	       DataTemplate.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DataTemplate     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? -   5        $??tbl_fornavn??5      $??0??5      $??0??5      $??0,0,20,5q?5      $??Fornavn??5      ?? 5    
   -   5        $??
tb_fornavn??5!      $??0??5"      $??1??5#      $	??Top=?5$      $??5,0,0,0q?5%      ?? 5'   
   -   5        $??tbl_efternavn??5(      $??1??5)      $??0??5*      $??0,0,20,5q?5+      $??	Efternavn??5,      ?? 5.   
   -   5        $??tb_efternavn??5/      $??1??50      $??1??51      $	??Top=?52      $??5,0,0,0q?53      ??54      ?? *person.Efternavn+?? 57   
   -   5        $??
tbl_formue??58      $??2??59      $??0??5:      $??0,0,20,5q?5;      $??Formue??5<      ?? 5>   
   -   5        $??	tb_formue??5?      $??2??5@      $??1??5A      $	??Top=?5B      $??5,0,0,0q?5C      ??5D      ?? *person.Formue+?? 5F   
   $??3??5G      $??0??5H      $??0,0,20,5q?5I      $??	ID nummer??5J      ?? 5L   
   -   5        $??tb_IDNummer??5M      $??3??5N      $??1??5O      $	??Top=?5P      $??5,0,0,0q?5Q      $6??0skriv ID nummeret på den person du vil ændre i??5R      ?? 5T   
   -   5        $??
btn_insert??5U      $??2??5V      $??4??5W      $??Insert??5X      $??20??67   ?? 5Z   
   -	   5        $??
btn_update??5[      $??2??5\      $??5??5]      $??Update??5^      6   ?? 5`   
   -
   5        $??
btn_delete??5a      $??2??5b      $??6??5c      $??delete??5d      6   &   System.Windows.Controls.DataGrid  5f   
   -   5        $??dg_personer??5g      $??7??5h      $??2??5i         AutoGenerateColumns$
 True??5k         
IsReadOnly$
 True??5l      ??5j      ?? *
Personer+5l      5n      5o      