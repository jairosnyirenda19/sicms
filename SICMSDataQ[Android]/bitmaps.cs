public class SaveImage
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public byte[] Array { get; set; }
        public SaveImage()
        {
        }
    }
 

//#####################
 
private SQLiteConnection _sqlconnection;  
_sqlconnection = DependencyService.Get<IDBInterface>().CreateConnection();
_sqlconnection.CreateTable<SaveImage>();
 
 

//###################

editor.ImageSaving += ImageSaving;
 
void ImageSaving(Object sender, ImageSavingEventArgs args)
        {
            var stream = args.Stream;
            array = ConvertStreamtoByte(stream);
            InsertImage(array);
        }
 
public static byte[] ConvertStreamtoByte(Stream input)
        {
            using (var ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
 
public void InsertImage(byte[] array)
        {
            string query = "insert into SaveImage (Array) values (@Array)";
            var cmd = _sqlconnection.CreateCommand(query, array);
            cmd.CommandText = "INSERT INTO SaveImage(Array) VALUES (@Array)";
            cmd.ExecuteNonQuery();
            var path = DependencyService.Get<IDBInterface>().GetPath();
            DisplayAlert("Saved In Location", path, "OK");
 
        }
 
 
 

//########################


 
int id = 1;
var array= _sqlconnection.Table<SaveImage>().FirstOrDefault(t =>t.id == id).Array;
 

//########################

MemoryStream stream = new MemoryStream();
bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
byte[] bitmapData = stream.ToArray();



//#######################


// convert from bitmap to byte array
public byte[] getBytesFromBitmap(Bitmap bitmap) {
    ByteArrayOutputStream stream = new ByteArrayOutputStream();
    bitmap.compress(CompressFormat.JPEG, 70, stream);
    return stream.toByteArray();
}



textView.setPaintFlags(textView.getPaintFlags() | Paint.UNDERLINE_TEXT_FLAG)