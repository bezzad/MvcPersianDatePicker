using System;
using System.Web.Mvc;

namespace PersianDatePicker.Helper
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString PersianDatePickerItem(this HtmlHelper htmlHelper, string id, bool hasTime, DataPlacement datePickerPlacement = DataPlacement.Bottom)
        {
            id = id ?? Guid.NewGuid().ToString();

            var div = new TagBuilder("div");
            div.AddCssClass("form-group");

            div.InnerHtml = $@"<div class='input-group'>
                                    <div class='input-group-addon' data-MdDateTimePicker='true' data-enabletimepicker='{hasTime.ToString().ToLower()}' data-targetselector='#{id}' data-placement='{datePickerPlacement.ToString().ToLower()}'  data-trigger='click'>
                                        <span class='glyphicon glyphicon-calendar'></span>
                                    </div>
                                    <input style='text-align: center;' type='text' class='form-control' data-MdDateTimePicker='true' id='{id}' data-enabletimepicker='{hasTime.ToString().ToLower()}' placeholder='تاریخ'  data-placement='{datePickerPlacement.ToString().ToLower()}' data-Trigger='focus' />
                                </div>";

            return MvcHtmlString.Create(div.ToString());
        }
        public static MvcHtmlString PersianDatePickerItem(this HtmlHelper htmlHelper, bool hasTime, DataPlacement datePickerPlacement = DataPlacement.Bottom)
        {
            return htmlHelper.PersianDatePickerItem(null, hasTime, datePickerPlacement);
        }
        public static MvcHtmlString PersianDatePickerItem(this HtmlHelper htmlHelper, DataPlacement datePickerPlacement = DataPlacement.Bottom)
        {
            return htmlHelper.PersianDatePickerItem(null, false, datePickerPlacement);
        }


        public static MvcHtmlString PersianFromToDatePickerItem(this HtmlHelper htmlHelper, string fromId, string toId, bool hasTime, DataPlacement datePickerPlacement = DataPlacement.Bottom)
        {
            fromId = fromId ?? Guid.NewGuid().ToString();
            toId = toId ?? Guid.NewGuid().ToString();
            var groupid = Guid.NewGuid();
            var div = new TagBuilder("div");
            div.AddCssClass("row");

            div.InnerHtml = $@"<div class='col-xs-6'>
                                    <div class='input-group'>
                                        <div class='input-group-addon' data-MdDateTimePicker='true' data-trigger='click' data-targetselector='#{toId}' data-groupid='group1' data-todate='true' data-enabletimepicker='{hasTime.ToString().ToLower()}' data-placement='{datePickerPlacement.ToString().ToLower()}'>
                                            <span class='glyphicon glyphicon-calendar'></span>
                                        </div>
                                        <input style='text-align: center;' type='text' class='form-control' id='{toId}' placeholder='تا تاریخ' data-MdDateTimePicker='true' data-Trigger='focus' data-targetselector='#{toId}' data-enabletimepicker='{hasTime.ToString().ToLower()}' data-groupid='{groupid}' data-todate='true'  data-placement='{datePickerPlacement.ToString().ToLower()}' />
                                    </div>
                                </div>
                                <div class='col-xs-6'>
                                    <div class='input-group'>
                                        <div class='input-group-addon' data-MdDateTimePicker='true' data-trigger='click' data-targetselector='#{fromId}' data-groupid='{groupid}' data-fromdate='true' data-enabletimepicker='{hasTime.ToString().ToLower()}' data-placement='{datePickerPlacement.ToString().ToLower()}'>
                                            <span class='glyphicon glyphicon-calendar'></span>
                                        </div>
                                        <input style='text-align: center;' type='text' class='form-control' id='{fromId}' placeholder='از تاریخ' data-MdDateTimePicker='true' data-Trigger='focus' data-targetselector='#{fromId}' data-groupid='{groupid}' data-fromdate='true' data-enabletimepicker='{hasTime.ToString().ToLower()}' data-placement='{datePickerPlacement.ToString().ToLower()}' />
                                    </div>
                                </div>";

            return MvcHtmlString.Create(div.ToString());
        }
        public static MvcHtmlString PersianFromToDatePickerItem(this HtmlHelper htmlHelper, bool hasTime, DataPlacement datePickerPlacement = DataPlacement.Bottom)
        {
            return htmlHelper.PersianFromToDatePickerItem(null, null, hasTime, datePickerPlacement);
        }
        public static MvcHtmlString PersianFromToDatePickerItem(this HtmlHelper htmlHelper, DataPlacement datePickerPlacement = DataPlacement.Bottom)
        {
            return htmlHelper.PersianFromToDatePickerItem(null, null, false, datePickerPlacement);
        }
    }

    public enum DataPlacement
    {
        Bottom,
        Right
    }
}
