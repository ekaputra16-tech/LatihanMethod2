int jumlahitem;

decimal hargaitem, diskon, totalbayar;

static decimal hitungDiskon(int jul_item)
{
    if (jul_item == 5) return 50000;
    else if (jul_item == 10) return 75000;
    else return 0;
}

static decimal hitungtotal(int jul_item, decimal hargaitem, decimal diskon)
{
    return jul_item * hargaitem + diskon;
}

Console.Write("Masukkan Jumlah Item: ");
jumlahitem = int.Parse(Console.ReadLine());

Console.Write("Masukkan harga Per-item: ");
hargaitem = decimal.Parse(Console.ReadLine());

diskon = hitungDiskon(jumlahitem);

totalbayar = hitungtotal(jumlahitem, hargaitem, diskon);

Console.WriteLine($"Diskon Yang diperoleh: Rp {totalbayar}");



