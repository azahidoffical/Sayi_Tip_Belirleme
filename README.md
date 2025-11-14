<img width="1920" height="1080" alt="Ekran Görüntüsü (115)" src="https://github.com/user-attachments/assets/b7c85bd9-ee06-449f-a8e8-8e88194f39b1" />
📌 Sayı Kontrol Uygulaması

(Mükemmel – Zengin – Fakir – Asal – Tek/Çift Analizi)

Bu Windows Forms uygulaması, kullanıcının girdiği bir sayıyı analiz ederek sayının:

✔ Mükemmel sayı mı
✔ Zengin sayı mı
✔ Fakir sayı mı
✔ Asal mı
✔ Tek mi / Çift mi
✔ Bölenlerini ve bölenlerin toplamını

hesaplayıp ekranda listeleyen basit ve öğretici bir C# projesidir.

🖼️ Arayüz

Uygulama temel olarak şunlardan oluşur:

📥 Sayı girişi için TextBox

🧮 Kontrol Et butonu

📋 Sonuçların listelendiği ListBox

🎯 Başlık ve tasarım düzenlemeleri

🚀 Özellikler
🔸 1. Bölenleri Listeleme

Girilen sayının tüm pozitif bölenleri ListBox'ta gösterilir.

🔸 2. Bölenlerin Toplamını Hesaplama

Tüm bölenlerin toplamı ayrıca listelenir.

🔸 3. Sayının Tipini Belirleme

Program sayıyı aşağıdaki kategorilere ayırır:

Mükemmel Sayı → bölenlerinin toplamı sayıya eşit

Zengin Sayı → bölenlerinin toplamı sayıdan büyük

Fakir Sayı → bölenlerinin toplamı sayıdan küçük

🔸 4. Asallık Kontrolü

Sayının asal olup olmadığı hesaplanır.

🔸 5. Tek / Çift Kontrolü

Sayı mod 2’ye göre değerlendirilir.

🧠 Kullanılan Temel Algoritmalar

Döngü ile bölenleri bulma

Toplam hesaplama

Asallık kontrolünde √n optimizasyonu

Koşullu durumlarla sınıflandırma

🧩 Örnek Kod (Kontrol Et Butonu)
private void btnKontrol_Click(object sender, EventArgs e)
{
    lbSonuc.Items.Clear();

    int sayi = Convert.ToInt32(tbGirdi.Text);

    int toplam = 0;

    for (int i = 1; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            toplam += i;
            lbSonuc.Items.Add(i);
        }
    }

    lbSonuc.Items.Add("---------------------------");
    lbSonuc.Items.Add("Bölenlerin Toplamı: " + toplam);
    lbSonuc.Items.Add("---------------------------");

    if (toplam == sayi)
        lbSonuc.Items.Add($"{sayi} MÜKEMMEL sayıdır.");
    else if (toplam > sayi)
        lbSonuc.Items.Add($"{sayi} ZENGİN sayıdır.");
    else
        lbSonuc.Items.Add($"{sayi} FAKİR sayıdır.");

    if (sayi % 2 == 0)
        lbSonuc.Items.Add($"{sayi} ÇİFT sayıdır.");
    else
        lbSonuc.Items.Add($"{sayi} TEK sayıdır.");

    bool asal = true;
    if (sayi < 2) asal = false;
    else
    {
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
            {
                asal = false;
                break;
            }
        }
    }

    if (asal)
        lbSonuc.Items.Add($"{sayi} ASAL sayıdır.");
    else
        lbSonuc.Items.Add($"{sayi} ASAL değildir.");
}

🛠️ Kullanılan Teknolojiler

C# .NET Framework

Windows Forms

Visual Studio 2022

📦 Projeyi Çalıştırma

Bu projeyi indir

Visual Studio ile aç

Form1.cs içinde gerekli düzenlemeleri yap (isteğe bağlı)

Başlat (F5) tuşuna bas

👤 Geliştirici

azahidoffical
📸 Portfolyo
🔗 https://www.azahidoffical.com.tr
