using System;

namespace fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor=ConsoleColor.DarkBlue; //definimos el color de fondo
            Console.ForegroundColor=ConsoleColor.White;  //definimos el text
            Console.Clear();

            int dia=0,mes=0,año=0;
            double cal1, cal2,cal3;
            string meschar="";
            int mesdia=0,cont1=1,cont2=1,cont3=1;
            int bandera1=0,bandera2=0,bandera3=0;
            string imp;

            do{
                if(cont1==1)
                {
                    do{
                     /* Try insertamos el codigo propenso a fallar*/
                    try{
                    Console.Write("\n Ingresar el numero del mes= ");
                    mes= Convert.ToInt32(Console.ReadLine()); 
                    bandera1=0;
                    }
                    /* Catch agarra el error y realiza el siguiente paso*/
                    catch{
                    Console.Write("\n Error al ingresar un dato no valido ");
                    bandera1=1;
                    }
                    //findo while
                    }
                    while (bandera1==1);  
                }
                else{
                    do{
                     /* Try insertamos el codigo propenso a fallar*/
                    try{
                    Console.Write("\n Error al ingresar el numero del mes intento Nª "+cont1+" = ");
                    mes= Convert.ToInt32(Console.ReadLine());
                    bandera1=0;
                    }
                    catch{
                    Console.Write("\n Error al ingresar un dato no valido ");
                    bandera1=1;
                    cont1=cont1+1;  
                    }
                    //findo while
                    }
                    while (bandera1==1);                      
                }
                 cont1=cont1+1;       
            }
            while ( mes<1 || mes>12 );


            do{   
                if(cont2==1)
                {
                    do{
                     /* Try insertamos el codigo propenso a fallar*/
                    try{
                    Console.Write("\n Ingresar el numero del año= ");
                    año= Convert.ToInt32(Console.ReadLine());
                    bandera2=0;
                    }
                    catch{
                    Console.Write("\n Error al ingresar un dato no valido ");
                    bandera2=1;
                    }
                    //findo while
                    }
                    while (bandera2==1);                
                }
                else{
                    do{
                     /* Try insertamos el codigo propenso a fallar*/
                    try{
                    Console.Write("\n Error al ingresar el numero del año intento Nª "+cont2+" = ");
                    año= Convert.ToInt32(Console.ReadLine());
                    bandera2=0;
                    }
                    catch{
                    Console.Write("\n Error al ingresar un dato no valido ");
                    bandera2=1;
                    cont2=cont2+1; 
                    }
                    //findo while
                    }
                    while (bandera2==1);         
                }
                 cont2=cont2+1;                
            }
            while ( año<1900 || año>2022 );


            cal1=año%4; //porcentaje para calcular el resto
            cal2=año%100;
            cal3=año%400;


if (año>=1900 && año<=2022) 
{
    if (cal1==0 && cal2 != 0 || cal3==0)
    {      
        switch(mes)
        {
         case 1 :
          mesdia=31;
         break;
         
         case 2 :
          mesdia=29;
         break;

         
         case 3 :
          mesdia=31;
         break;
         
         case 4 :
          mesdia=30;
         break;
         
         case 5 :
          mesdia=31;
         break;
         
         case 6 :
          mesdia=30;
         break;
         
         case 7 :
          mesdia=31;
         break;
         
         case 8 :
          mesdia=31;
         break;

         case 9 :
          mesdia=30;
         break;
         
         case 10 :
          mesdia=31;
         break;
         
         case 11 :
          mesdia=30;
         break;
         
         case 12 :
          mesdia=31;
         break;
        } 
     
      do{
            if(cont3==1)
                {
                    do{
                     /* Try insertamos el codigo propenso a fallar*/
                    try{
                    Console.Write("\n Ingresar el numero del día= ");
                    dia= Convert.ToInt32(Console.ReadLine());
                    bandera3=0;
                    }
                    catch{
                    Console.Write("\n Error al ingresar un dato no valido ");
                    bandera3=1;
                    }
                    //findo while
                    }
                    while (bandera3==1); 
                    
                }
                else{
                    do{
                     /* Try insertamos el codigo propenso a fallar*/
                    try{
                    Console.Write("\n Error al ingresar el numero del día intento Nª "+cont3+" = ");
                    dia= Convert.ToInt32(Console.ReadLine());
                    bandera3=0;
                    }
                    catch{
                    Console.Write("\n Error al ingresar un dato no valido ");
                    bandera3=1;
                    cont3=cont3+1;
                    }
                    //findo while
                    }
                    while (bandera3==1);                     
                }
                 cont3=cont3+1;   
            }
            while ( dia > mesdia || dia<1); 
    
    if(dia==mesdia)
    {
        dia=1;
        mes=mes+1;
        if(mes==12)
        {
            mes=1;
            año=año+1;
        }

    }
    else{
        dia=dia+1;
    }
    }

else
     { 
    switch(mes)
        {
         case 1 :
          mesdia=31;
         break;
         
         case 2 :
          mesdia=28;
         break;
    
         case 3 :
          mesdia=31;
         break;
         
         case 4 :
          mesdia=30;
         break;
         
         case 5 :
          mesdia=31;
         break;
         
         case 6 :
          mesdia=30;
         break;
         
         case 7 :
          mesdia=31;
         break;
         
         case 8 :
          mesdia=31;
         break;

         case 9 :
          mesdia=30;
         break;
         
         case 10 :
          mesdia=31;
         break;
         
         case 11 :
          mesdia=30;
         break;
         
         case 12 :
          mesdia=31;
         break;
        }

              do
              {
                if(cont3==1)
                {
                    do{
                     /* Try insertamos el codigo propenso a fallar*/
                    try{
                    Console.Write("\n Ingresar el numero del día= ");
                    dia= Convert.ToInt32(Console.ReadLine());
                    bandera3=0;
                    }
                    catch{
                    Console.Write("\n Error al ingresar un dato no valido ");
                    bandera3=1;
                    }
                    //findo while
                    }
                    while (bandera3==1); 
                }
                else{
                    do{
                     /* Try insertamos el codigo propenso a fallar*/
                    try{
                    Console.Write("\n Error al ingresar el numero del día intento Nª "+cont3+" = ");
                    dia= Convert.ToInt32(Console.ReadLine());
                    bandera3=0;
                    }
                    catch{
                    Console.Write("\n Error al ingresar un dato no valido ");
                    bandera3=1;
                    cont3=cont3+1;
                    }
                    //findo while
                    }
                    while (bandera3==1); 
                }
                cont3=cont3+1;   

              }
            while ( dia > mesdia || dia<1); 

    if(dia==mesdia)
    {
        dia=1;
        mes=mes+1;
        if(mes==12)
        {
            mes=1;
            año=año+1;
        }

    }
    else{
        dia=dia+1;
    }
} 
     switch(mes)
        {
         case 1 :
          meschar="Enero";
         break;
         
         case 2 :
          meschar="Febrero";
         break;
    
         case 3 :
          meschar="Marzo";
         break;
         
         case 4 :
          meschar="Abril";
         break;
         
         case 5 :
          meschar="Mayo";
         break;
         
         case 6 :
          meschar="Junio";
         break;
         
         case 7 :
          meschar="Julio";
         break;
         
         case 8 :
          meschar="Agosto";
         break;

         case 9 :
          meschar="Septiembre";
         break;
         
         case 10 :
          meschar="Octubre";
         break;
         
         case 11 :
          meschar="Noviembre";
         break;
         
         case 12 :
          meschar="Diciembre";
         break;
        }

        Console.BackgroundColor=ConsoleColor.Green; //definimos el color de fondo
        Console.ForegroundColor=ConsoleColor.Black;  //definimos el text
        Console.Clear();
        
        Console.WriteLine("\n*************************************************"); 
        Console.WriteLine("\n"); 
        imp=  "El dia siguiente es  "+dia+" de "+ meschar+", del año "+año;       
        Console.WriteLine("\n"+imp);  
        Console.WriteLine("\n"); 
        Console.WriteLine("\n*************************************************");         
        Console.WriteLine("\n"); 
        Console.WriteLine("\n"); 
}

}
}
}

