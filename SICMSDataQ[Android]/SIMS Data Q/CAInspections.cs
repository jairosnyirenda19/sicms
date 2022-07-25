using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace SIMS_BARS
{
    class CAInspections : BaseAdapter
    {
        private readonly Context @context;
        private readonly JavaList<ListMenuItems> @listMenuItems;
        private LayoutInflater @inflater;

        public CAInspections(Context @context, JavaList<ListMenuItems> @listMenuItems) 
        {
            this.context = @context;
            this.listMenuItems = @listMenuItems;
        }

        public override Object GetItem(int position) 
        {
            return @listMenuItems.Get(position);
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent) 
        {
            if (inflater == null) 
                inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);

            if (convertView == null)
                convertView = inflater.Inflate(Resource.Layout.StartListView, parent, false);

            CAViewHolderInspection holder = new CAViewHolderInspection(convertView)
            {
                NameTxt = { Text = listMenuItems[position].Name }
            };
            holder.Img.SetImageResource(listMenuItems[position].Image);
            return convertView;
        }

        public override int Count 
        {
            get { return listMenuItems.Size(); }
        }
    }

    class CAViewHolderInspection : Object
    {
        public TextView NameTxt;
        public ImageView Img;

        public CAViewHolderInspection(View ItemView)
        {
            NameTxt = ItemView.FindViewById<TextView>(Resource.Id.nameText);
            Img = ItemView.FindViewById<ImageView>(Resource.Id.IconImage);
        }
    }   
}
