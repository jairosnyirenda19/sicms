using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace SIMS_BARS
{
    class CA : BaseAdapter
    {
        private readonly Context @context;
        private readonly JavaList<ListMenuItems> @listMenuItems;
        private LayoutInflater @inflater;

        public CA(Context @context, JavaList<ListMenuItems> @listMenuItems) 
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

            CustomAdapterViewHolder holder = new CustomAdapterViewHolder(convertView)
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

    class CustomAdapterViewHolder : Object
    {
        public TextView NameTxt;
        public ImageView Img;

        public CustomAdapterViewHolder(View ItemView)
        {
            NameTxt = ItemView.FindViewById<TextView>(Resource.Id.nameText);
            Img = ItemView.FindViewById<ImageView>(Resource.Id.IconImage);
        }
    }   
}