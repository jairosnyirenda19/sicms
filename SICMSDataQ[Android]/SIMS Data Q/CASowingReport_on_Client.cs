using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using SIMS_BARS.Models;

namespace SIMS_BARS
{
    class CASowingReport_on_Client : BaseAdapter
    {
        private readonly Context @context;
        private readonly JavaList<SowingListItem> @listsowing_report_on_client_View;
        private LayoutInflater @inflater;

        public CASowingReport_on_Client(Context @context, JavaList<SowingListItem> @listsowing_report_on_client_View)
        {
            this.context = @context;
            this.@listsowing_report_on_client_View = @listsowing_report_on_client_View;
        }

        public override Object GetItem(int position)
        {
            return @listsowing_report_on_client_View.Get(position);
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
                convertView = inflater.Inflate(Resource.Layout.SowingReportDesign, parent, false);

            CAViewHolderSowingReport_on_Client holder = new CAViewHolderSowingReport_on_Client(convertView)
            {
                IdTxt = { Text = @listsowing_report_on_client_View[position].Sowing_id_list.ToString() },
                CropTxt = { Text = @listsowing_report_on_client_View[position].Cropname },
                ClassTxt = { Text = @listsowing_report_on_client_View[position].Seedclass },
                DateofsowingTxt = { Text = @listsowing_report_on_client_View[position].Date.ToShortDateString() }
            };

            holder.Img.SetImageResource(@listsowing_report_on_client_View[position].Image);
            return convertView;
        }

        public override int Count
        {
            get { return @listsowing_report_on_client_View.Size(); }
        }
    }

    public class CAViewHolderSowingReport_on_Client : Object
    {
        public TextView IdTxt;
        public TextView CropTxt;
        public TextView ClassTxt;
        public TextView DateofsowingTxt;
        public ImageView Img;

        public CAViewHolderSowingReport_on_Client(View ItemView)
        {
            IdTxt = ItemView.FindViewById<TextView>(Resource.Id.IdTextSowingReport);
            CropTxt = ItemView.FindViewById<TextView>(Resource.Id.cropTextSowingReport);
            ClassTxt = ItemView.FindViewById<TextView>(Resource.Id.classofseedText);
            DateofsowingTxt = ItemView.FindViewById<TextView>(Resource.Id.dateofsowingText);
            Img = ItemView.FindViewById<ImageView>(Resource.Id.IconImageSowingReport);
        }
    }
}