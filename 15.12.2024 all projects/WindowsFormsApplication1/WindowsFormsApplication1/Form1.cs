using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//Referanslar dışında olan global değişkenleri tanimlamış olduk.
        }
        Random rnd = new Random();//Random değişken tanımladık.
        int[] deger = new int[50];//50. Elemana kadar dizi tanımladık.

        private void button1_Click(object sender, EventArgs e)//Kontrol etme butonu
        {
            for (int i = 0; i < 50; i++)// 1 den 50 ye Kadar devamlı  1 artan döngü kurduk. 
                deger[i] = rnd.Next(1, 100);//1 den 100 e Kadar rastgele sayıları tanımladık.
            MessageBox.Show("dizi oluşturuldu");//Dizinin oluşturduğunu gösteren bir mesaj penceresi ekledik.
        }
        int elemancount = 0;//Global değişken:eleman değerini sıfırladık.

        private void button2_Click(object sender, EventArgs e)//Liste kutusuna ekleme butonu
        {
            listBox1.Items.Clear();//Liste kutusunu tamamen sildik.
            for (int i = 0; i < 50; i++)// 1 den 50 ye Kadar devamlı  1 artan döngü kurduk. 
                listBox1.Items.Add(deger[i]);//1 den 100 e Kadar olan rastgele sayıları 50 eleman olacak şekilde ekledik.

            elemancount = deger.Length - 1;//Global değişken:eleman değerini liste kutusundaki değerlerin uzantısından 1 çıkardık. 

        }

        private void button4_Click(object sender, EventArgs e)//Seçilen son elemanı silen button yaptık .
        {
            int[] deger2 = new int[elemancount];
            //Dizi içine global değişken tanımladık .
            for (int i = 0; i < elemancount; i++)//Dizilerde olan referans noktasından başlayıp,global değişkenimizdenküçük olmak şartıyla devamlı arttırdık. 
            {
                deger2[i] = deger[i];//Tanımlanan değişken,1 den 100 e kadar olan ve 50 elemanı olan rastgele sayılara aktardık.
                listBox1.Items.Add(deger2[i]);//Böylece liste kutusuna 1 den 100 e kadar olan rastgele sayıları dolaylı yoldan eklemiş olduk. 
            }
            if (elemancount > 0)//Eğer tanımlanan değişken 0 dan büyükse 
                elemancount--;//Her tıklamada devamlı 1 eksilt
            label1.Text = "Items count =" + (deger2.Length - 1).ToString();//Ve bu degeri dolaylı yoldan göstermek ve uzantısını alıp 1 çıkarmak, Aynı zamanda metinsele çevirip gösterdik. 
        }

        private void button5_Click(object sender, EventArgs e)//Sayıları küçükten büyüğe sıralayan button
        {
            int yedek = 0;//Yedek adlı bir değişken tanımladık.
            listBox1.Items.Clear();//Verileri tamamen sildik.
            for (int i = 0; i < deger.Length - 1; i++)//0 dan başlayıp 1 den 100 e Kadar olan rastgele sayıların uzantısından küçük ve devamlı arttırdık.
            {
                for (int j = i; j < deger.Length - 1; j++)//Onun içerisine "deger" ifadesine eşit olan ve bu değeri- bir eksiğini kullanarak i nin j dendaha büyük olduğunu gösterdik. 
                {
                    if (deger[i] > deger[j])//Eğer i ,j den büyükse
                    {
                        yedek = deger[i];//Boş olan değişkene i değişkeninin prensibini aktardık.Böylece i değerideki prensibin artık olmadığını öne sürdük.
                        deger[i] = deger[j];//Sonra i yi j ye tanımladık. 
                        deger[j] = yedek;//Bu sayede j nin "yedek" değerine eşitledik.


                    }
                }


                listBox1.Items.Add(deger[i]);//Geriye kalan bu çalışma prensibini tekrardan "değer" değişkenine atayarak hem rastgele verileri sıfırladık hemde 1 den 100 e  kadar olan rastgele sayıları küçükten büyüğe sıralamış olduk. 

            }
        }
        private void button3_Click(object sender, EventArgs e)//Liste kutusundaki verilerin tamamını silen button
        {
            listBox1.Items.Clear();//Listboxtaki tüm verileri siler.
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //listBox1.Items.Remove(listBox1.SelectedIndex);//liste kutusundaki seçilen  elemanları silme

            listBox1.Items.Clear();//Tüm verileri sildik.
            int dizideki_sayi = deger.Length - 1;//Dizideki sayıların uzantısından bir çıkararak "dizideki_sayi"komutunu aktardık.


            for (int i = 0; i < dizideki_sayi; i++)//Dizideki sayı komutunu   elemanların uzantısı olarak devamlı ekledik.
            {
                for (int j = i + 1; j < dizideki_sayi; j++)//karşılaştırmak amacıyla i degerini j ye atadık.Böylece iki döngü de eşit olacak.
                {
                    if (deger[i] == deger[j])//Eğer i döngüsü j ye eşitse
                    {
                        for (int k = j; k < dizideki_sayi; k++)//Yedi bir döngü olan k ye aktardık.  
                             deger[k] = deger[k + 1];//Ve bu değeri "k" döngüsüne aktararak bu "k" döngüsünü "k+1" olarak aktardık.
                        dizideki_sayi--;//Böylece dizideki her bir eleman silinecek.
                        j--;//Bu da j döngüsünü çalıştıracak.



                    }
                }
            }
            for (int i = 0; i < dizideki_sayi; i++)//Bu işlemler yapıldıktan sonra tekrardan başka bir döngüye aktarılacak.
            {
                listBox1.Items.Add(deger[i]);//Aktarılan deger genel dizimiz olacak.
                label2.Text = "dizideki degerler=" + (listBox1.Items.Count).ToString();//Sonucu ise yazı kutusunda Metinsel hale çevirerek verilecek.
            }



        }

        private void button7_Click(object sender, EventArgs e)//hangi elemandan kaç tane olduğunu bulan button
        {
            int[]degerler=new int [50];//"degerler" adlı 50 elemana sahip bir dizi tanımladık.
            int bulunan_deger = 0;//Bulunan deger referans noktasından başlayıp 50. elemana kadar tarayacak
            for (int i = 0; i < deger.Length - 1; i++)//referans noktasından başlayıp Genel dizinin uzantısını aldık.
                degerler[i] = -1;//Bu tanımlanan diziyi sondan başa doğru başlattık.
            
                
                for(int i=0;i<deger.Length-1;i++)//Yeniden genel dizinin uzantısını ekledik.
                {
                    bulunan_deger = 1;//bulunacak olan değere 1  vererek ilerlemesini sağlayacağız.
                   for(int j=i+1;j<deger.Length-1;j++)//Eklenen uzantıyı "j"  döngüsüne tanımladık ki bu değerleri tek tek taramak yoluyla birbirine eşitledik. 
                   {
                       if (deger[i] == deger[j])//Eğer bu iki dizi eşitse
                       {
                           bulunan_deger++;//Dizideki elemanları tara.
                           degerler[j] = 0;//Girilen son döngüyü sıfırladık.Bu Döngünün haricinde sonucu yazmak amacıyla yazdık.
                       }

                   }
                    if(degerler[i]!=0)//Dizinin uzantısı eğer eşit değilse
                    {
                        degerler[i] = bulunan_deger;//Taranan tüm değerleri bul.
                    }
                }
                listBox1.Items.Clear();//Liste kutusunu temizle.
                for(int i=0;i<deger.Length-1;i++)//Dizinin uzantısının bir eksiğini tanımladık
                {
                    if(degerler[i]!=0)//Değerler sıfıra eşit değilse
                    {
                        listBox1.Items.Add(deger[i] + "=" + degerler[i]);//Bu değerleri liste kutusuna ekle ve eklenen eleman sayısını göster.
                    }
                }
                      
                           
                       
                   

        }

        private void button8_Click(object sender, EventArgs e)
        {


           bool found=false;//bulunacak değer yanlış olarak girdik

           //Dizideki elemanı arama 1. Yöntem

          /* for (int i = 0; i < 10;i++ )
           {
               if (textBox1.Text == deger[i].ToString())
                   found = true;
               if (found == true)
               {
                   MessageBox.Show("deger bulundu.");
                   found = false;
               }
               else
               {
                   MessageBox.Show("deger bulunamadı.");
               }
           }*/
          
           
               for (int i = 0; i < 50;i++ )
           {
               if (textBox1.Text == deger[i].ToString())
                   found = true;
               if (deger.Contains(Convert.ToInt32(textBox1.Text)) == true)
                   MessageBox.Show("değer bulundu.");

               else
                   MessageBox.Show("deger bulunamadı.");
              
           }
            
        }
    }
}



