# Yum Yum Drop - Game 2D

![Gameplay Yum Yum Drop](https://github.com/Fernandotambun/2D_Game_Yum_Yum_Drop/blob/main/Gameplay.png)

**Yum Yum Drop** adalah sebuah game 2D di mana pemain mengendalikan karakter untuk mengumpulkan makanan yang jatuh. Tujuan dari permainan ini adalah mengumpulkan sebanyak mungkin makanan sambil menghindari rintangan. Repository ini hanya berisi script inti dari game.

## Tutorial

Untuk membantu Anda memahami dan mengatur game ini, kami menyediakan tutorial :

- **Tutorial PPT**: [Lihat PPT di sini](https://link-untuk-ppt.com)
- **Video Tutorial**: [Tonton video di sini](https://link-untuk-video.com)
- **Video Tutorial**: [Download Asset Disini](https://drive.google.com/drive/folders/1KQPp9dXY8qe5EE9yg8xPkabac0QcxHWh)

## Struktur Proyek

Repository ini hanya menyertakan script yang mengatur berbagai aspek permainan seperti pergerakan pemain, spawning makanan, dan manajemen UI.

- **PlayerMovement.cs**: Mengatur pergerakan karakter pemain.
- **SpawnFoods.cs**: Mengelola spawning item makanan di dalam permainan.
- **UiManager.cs**: Mengatur elemen-elemen antarmuka pengguna (UI) dalam permainan seperti tombol yang akan digunakan.
- **DestroyFood.cs**: Mengatur penghancuran item makanan setelah melewati batas playform/layar.
- **GameManager.cs**: Mengatur kondisi dan status permainan, seperti jumlah nyawa pemain, penghitungan skor, dan logika Game Over. Juga bertanggung jawab untuk manajemen state game dan alur permainan.
- **PlayerCollision.cs**: Mengatur deteksi makanan antara pemain dengan makanan.
