using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using SIMS_BARS.Models;

namespace SIMS_BARS
{
    class CAClients : BaseAdapter
    {
        private readonly Context @context;
        private readonly JavaList<Client> @listClientView;
        private LayoutInflater @inflater;

        public CAClients(Context @context, JavaList<Client> @listClientView)
        {
            this.context = @context;
            this.@listClientView = @listClientView;
        }

        public override Object GetItem(int position)
        {
            return @listClientView.Get(position);
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
                convertView = inflater.Inflate(Resource.Layout.ClientsListView, parent, false);

            CustomAdapterViewHolderClients holder = new CustomAdapterViewHolderClients(convertView)
            {
                IdTxt = { Text = @listClientView[position].customer_id.ToString()},
                NameTxt = { Text = @listClientView[position].full_name },
                ContactTxt = { Text = @listClientView[position].contact },
                DistrictTxt = { Text = @listClientView[position].joined.ToShortDateString() }
            };
            holder.Img.SetImageResource(@listClientView[position].Image);
            return convertView;
        }

        public override int Count
        {
            get { return @listClientView.Size(); }
        }
    }

    class CustomAdapterViewHolderClients : Object
    {
        public TextView IdTxt;
        public TextView NameTxt;
        public TextView ContactTxt;
        public TextView DistrictTxt;
        public ImageView Img;

        public CustomAdapterViewHolderClients(View ItemView)
        {
            IdTxt = ItemView.FindViewById<TextView>(Resource.Id.IdText);
            NameTxt = ItemView.FindViewById<TextView>(Resource.Id.nameTextClient);
            ContactTxt = ItemView.FindViewById<TextView>(Resource.Id.cropText);
            DistrictTxt = ItemView.FindViewById<TextView>(Resource.Id.districtText);
            Img = ItemView.FindViewById<ImageView>(Resource.Id.IconImageClients);
        }
    }
}