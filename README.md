# CSharpEğitimKampi501
# 📦 Product Management System (Ürün Yönetim Sistemi)

*[🇬🇧 For English version, scroll down](#-english)*

---

## 🇹🇷 Türkçe

Bu proje, **C#** ve **Windows Forms** kullanılarak geliştirilmiş, **Dapper ORM** ile veritabanı işlemlerini yöneten modern bir masaüstü uygulamasıdır.

Murat Yücedağ C# Eğitim Dersleri kapsamında geliştirilmiş olup, **Clean Code** prensipleri ve **Asenkron Programlama** teknikleri üzerine odaklanılmıştır.
Youtube Oynatma Listesi Linki: https://www.youtube.com/watch?v=oev5wH-_XCI&list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr 

Ekran Tasarımı Aşağıda Bulunmaktadır.

### 🚀 Projenin Amacı
Geleneksel ADO.NET yerine, daha performanslı ve hafif bir ORM olan **Dapper** kullanarak CRUD (Ekleme, Silme, Güncelleme, Listeleme) işlemlerini gerçekleştirmek ve katmanlı mimariye uygun, profesyonel bir kod yapısı oluşturmak.

### 🛠️ Kullanılan Teknolojiler ve Teknikler

* **Dil:** C# (.NET Framework)
* **Arayüz:** Windows Forms (WinForms)
* **Veritabanı:** MS SQL Server
* **ORM:** Dapper (Micro-ORM)
* **Mimari Yaklaşım:**
    * **Async/Await:** Arayüzü dondurmayan asenkron veritabanı sorguları.
    * **DTO (Data Transfer Objects):** Veri taşıma nesneleri ile güvenli veri akışı.
    * **Refactoring:** Değişken ve metot isimlendirmelerinde evrensel İngilizce standartları.
    * **Mapping (Eşleştirme):** SQL ve C# arasındaki isimlendirme farklarının (örn: `Product_ID` -> `productId`) yönetimi.

### ⚙️ Özellikler

- [x] **Ürün Listeleme:** Tüm ürünlerin veritabanından asenkron olarak çekilmesi.
- [x] **Yeni Ürün Ekleme:** Parametreli sorgularla güvenli veri girişi.
- [x] **Ürün Güncelleme & Silme:** ID bazlı işlemler.
- [x] **Get By ID:** Özel SQL sorgusu ve mapping ile tek bir ürünün detaylarının getirilmesi.
- [x] **İstatistikler:** Veritabanından anlık toplam ürün sayısı, stok durumu gibi verilerin çekilmesi.

### 💻 Kurulum

1.  Bu projeyi klonlayın:
    ```bash
    git clone [https://github.com/KULLANICI_ADIN/REPO_ADIN.git](https://github.com/KULLANICI_ADIN/REPO_ADIN.git)
    ```
2.  SQL Server'da `TblProduct` tablosunu oluşturun.
3.  `ConnectionString` ayarlarını kendi sunucunuza göre güncelleyin.
4.  Projeyi Visual Studio ile açıp `Start` butonuna basın.

---

## 🇬🇧 English

This project is a modern desktop application developed with **C#** and **Windows Forms**, managing database operations using **Dapper ORM**. 

It was developed as part of the **Murat Yücedağ C# Bootcamp Lessons**, focusing on **Clean Code** principles and **Asynchronous Programming** techniques instead of traditional ADO.NET methods.
The Youtube Playlist Link: https://www.youtube.com/watch?v=oev5wH-_XCI&list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr

UI design is located below the text.

### 🚀 Project Goal
To implement high-performance CRUD operations using **Dapper (Micro-ORM)** and to build a readable, maintainable codebase with a layered architecture approach.

### 🛠️ Tech Stack & Key Concepts

* **Language:** C# (.NET Framework)
* **UI:** Windows Forms (WinForms)
* **Database:** MS SQL Server
* **ORM:** Dapper (Micro-ORM)
* **Key Techniques:**
    * **Async/Await:** Non-blocking asynchronous database queries for a responsive UI.
    * **DTO (Data Transfer Objects):** Secure data flow with specific classes.
    * **Refactoring:** Clean Code standards with proper English naming conventions.
    * **Mapping:** Solving column name mismatches between SQL and C# using aliases (e.g., `Product_ID` -> `productId`).

### ⚙️ Features

- [x] **Product Listing:** Fetching data asynchronously and binding to DataGridView.
- [x] **Add Product:** Secure data entry with parameterized queries.
- [x] **Update & Delete:** ID-based management.
- [x] **Get By ID:** Fetching single product details with custom mapping.
- [x] **Statistics:** Real-time data aggregation (Count, Sum, Avg).

---
*Developed by Mert Harmandarlı*

<img width="983" height="540" alt="Screenshot 2026-01-31 181214" src="https://github.com/user-attachments/assets/7da7b51a-c8d4-47e8-a658-9fdef4812450" />
