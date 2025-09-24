<div align="center">
  <h1>📈 StockTracker – Stock Portfolio & Discussion Platform</h1>
  <p>
    StockTracker, kullanıcıların <strong>hisse senetlerini takip edebileceği</strong>, 
    <strong>kişiselleştirilmiş portföyler oluşturabileceği</strong> ve 
    <strong>yorum paylaşabileceği</strong> bir platform için geliştirilmiş 
    <strong>scalable backend</strong> projesidir.<br>
    Modern mimari prensiplerine uygun olarak tasarlanmış ve gelecekte mobil ile web 
    uygulamalarına entegre edilebilecek şekilde yapılandırılmıştır.
  </p>
</div>

<hr>

<h2>🚀 Özellikler</h2>
<ul>
  <li>🔐 <strong>JWT Authentication</strong> ile güvenli kullanıcı giriş sistemi</li>
  <li>📊 <strong>Portföy Yönetimi</strong> – Kullanıcıların hisselerini takip etmesi ve kaydetmesi</li>
  <li>💬 <strong>Yorum Sistemi</strong> – Hisse senetleri hakkında gerçek zamanlı tartışmalar</li>
  <li>⚡ <strong>Performanslı API</strong> – Pagination ve sorting ile optimize edilmiş veri akışı</li>
  <li>🧩 <strong>Repository Pattern & Dependency Injection</strong> – Modüler ve sürdürülebilir mimari</li>
  <li>🌐 <strong>RESTful API</strong> yapısı, mobil ve web entegrasyonuna hazır</li>
</ul>

<hr>

<h2>🛠 Kullanılan Teknolojiler</h2>
<table>
  <thead>
    <tr>
      <th>Teknoloji</th>
      <th>Amaç</th>
    </tr>
  </thead>
  <tbody>
    <tr><td><strong>.NET 8 (ASP.NET Core)</strong></td><td>Backend API geliştirme</td></tr>
    <tr><td><strong>Entity Framework Core</strong></td><td>Veritabanı yönetimi ve ORM</td></tr>
    <tr><td><strong>PostgreSQL</strong></td><td>Veritabanı</td></tr>
    <tr><td><strong>JWT (JSON Web Token)</strong></td><td>Authentication & Authorization</td></tr>
    <tr><td><strong>AutoMapper</strong></td><td>DTO ve model dönüşümleri</td></tr>
    <tr><td><strong>Dependency Injection</strong></td><td>Modüler ve bağımsız servis yapısı</td></tr>
    <tr><td><strong>LINQ & EF Core Pagination</strong></td><td>Optimize veri sorgulamaları</td></tr>
    <tr><td><strong>Swagger</strong></td><td>API dokümantasyonu</td></tr>
  </tbody>
</table>

<hr>

<h2>📂 Proje Yapısı</h2>
<pre>
StockTracker/
│
├── Controllers/       # API Controller'ları
├── Data/              # DbContext ve Seed verileri
├── Dtos/              # Data Transfer Object'ler
├── Interfaces/        # Repository Interface'leri
├── Mappers/           # AutoMapper Profilleri
├── Migrations/        # EF Core Migration dosyaları
├── Models/            # Entity Modelleri
├── Repository/        # Repository Implementasyonları
├── Program.cs         # Uygulama giriş noktası
└── appsettings.json   # Konfigürasyon ayarları
</pre>

<hr>

<h2>⚙️ Kurulum</h2>
<p>Projeyi lokal ortamınızda çalıştırmak için aşağıdaki adımları takip edin:</p>

<h3>1️⃣ Gerekli bağımlılıkları yükleyin</h3>
<ul>
  <li><a href="https://dotnet.microsoft.com/download/dotnet/8.0">.NET 8 SDK</a></li>
  <li><a href="https://www.postgresql.org/download/">PostgreSQL</a></li>
</ul>

<h3>2️⃣ Repository'yi klonlayın</h3>
<pre>
git clone https://github.com/mustafa-tezcan/stock.git
cd stock
</pre>

<h3>3️⃣ Veritabanı bağlantısını yapılandırın</h3>
<p><code>appsettings.json</code> dosyasında PostgreSQL bağlantı stringinizi güncelleyin:</p>
<pre>
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=StockDB;Username=postgres;Password=yourpassword"
}
</pre>

<h3>4️⃣ Migration ve Database oluşturun</h3>
<pre>
dotnet ef database update
</pre>

<h3>5️⃣ Uygulamayı çalıştırın</h3>
<pre>
dotnet run
</pre>

<hr>

<h2>🌐 Swagger UI</h2>
<p>
API endpointlerini test etmek için <a href="https://swagger.io/">Swagger</a> arayüzüne erişebilirsiniz.<br>
Uygulama çalıştığında tarayıcınızda şu adresi açın:
</p>
<pre>
http://localhost:5000/swagger
</pre>

<hr>

<h2>📸 Ekran Görüntüleri</h2>
<p>
  Swagger UI ve API yanıtlarını gösteren ekran görüntülerini buraya ekleyebilirsiniz.<br>
  <em>Örn:</em> <img src="docs/images/swagger.png" alt="Swagger UI" width="600">
</p>

<hr>

<h2>🗺 Yol Haritası</h2>
<ul>
  <li>[ ] SignalR ile gerçek zamanlı bildirimler</li>
  <li>[ ] Birden fazla portföy desteği</li>
  <li>[ ] Üyelik seviyelerine göre yetkilendirme</li>
  <li>[ ] Mobil uygulama entegrasyonu (React Native)</li>
</ul>

<hr>

<h2>🤝 Katkıda Bulunma</h2>
<ol>
  <li>Fork yapın 🍴</li>
  <li>Yeni bir branch oluşturun: <code>git checkout -b feature/yeni-ozellik</code></li>
  <li>Değişikliklerinizi commit edin: <code>git commit -m 'Yeni özellik eklendi'</code></li>
  <li>Branch'i push edin: <code>git push origin feature/yeni-ozellik</code></li>
  <li>Pull request açın 🎉</li>
</ol>

<hr>

<h2>📜 Lisans</h2>
<p>
  Bu proje <strong>MIT Lisansı</strong> ile lisanslanmıştır. Daha fazla bilgi için 
  <code>LICENSE</code> dosyasına göz atın.
</p>

<hr>

<h2>👤 Geliştirici</h2>
<p>
  <strong>Mustafa Tezcan</strong><br>
  <a href="https://github.com/mustafa-tezcan">GitHub</a> • 
  <a href="https://linkedin.com/in/mustafa-tezcan">LinkedIn</a>
</p>

