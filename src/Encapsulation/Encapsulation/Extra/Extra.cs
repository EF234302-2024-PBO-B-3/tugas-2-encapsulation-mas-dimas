using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra;

/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 */


/*
 * Saya membuat sebuah soal yang berhubungan dengan Spotify karena saat ini saya sedang mendengarkan Spotify.
 * Kelas yang saya buat adalah kelas SpotifySong yang memiliki private atribute string _titleName, string _artistName, int _duration, bool _favoriteSong.
 * Kemudian, saya membuat konstruktor yang menerima parameter input titleName, artistName, duration, dan Favorite.
 * Untuk setiap atribut, memiliki properti public get public dan set private.
 * Diberikan pula validasi untuk TitleName dan ArtistName, yaitu jika kosong maka akan diisi dengan "Unknown".
 * Untuk Duration, jika kurang dari 0 maka akan diisi dengan 0. Sedangkan untuk Favorite, berupa true or false
 * Selanjutnya saya juga menambahkan metode DisplaySong yang akan menampilkan informasi lagu.
 * Saya juga menambahkan metode FavoriteSong untuk melihat lagu favorite.
 */


/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

public class SpotifySong
{
    private string _titleName;
    private string _artistName;
    private int _duration;
    private bool _favoriteSong;

    public string TitleName
    {
        get { return _titleName; }
        private set { _titleName = string.IsNullOrEmpty(value) ? "Unknown" : value; }
    }

    public string ArtistName
    {
        get { return _artistName; }
        private set { _artistName = string.IsNullOrEmpty(value) ? "Unknown" : value; }
    }
    public int Duration
    {
        get { return _duration; }
        private set { _duration = value < 0 ? 0 : value; }
    }

    public bool FavoriteSong
    {
        get { return _favoriteSong; }
        private set { _favoriteSong = value; }
    }

    public SpotifySong(string titleName, string artistName, int duration, bool favoriteSong)
    {
        _titleName = string.IsNullOrEmpty(titleName) ? "Unknown" : titleName; ;
        _artistName = string.IsNullOrEmpty(artistName) ? "Unknown" : artistName;
        Duration = duration;
        FavoriteSong = favoriteSong;
    }

    public void DisplaySong()
    {
        Console.WriteLine($"Title: {TitleName}, Artist: {ArtistName}, Duration: {Duration} seconds, Favorites: {FavoriteSong}");
    }

    public static void DisplayFavoriteSong(List<SpotifySong> songs)
    {
        foreach (var song in songs)
        {
            if (song.FavoriteSong)
            {
                song.DisplaySong();
                Console.WriteLine();
            }
        }
    }
}

