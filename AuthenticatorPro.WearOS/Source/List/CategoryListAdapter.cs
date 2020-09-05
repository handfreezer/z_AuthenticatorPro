﻿using Android.Content;
using Android.Graphics.Drawables;
using AndroidX.Wear.Widget.Drawer;
using AuthenticatorPro.Shared.Query;
using AuthenticatorPro.WearOS.Cache;
using Java.Lang;

namespace AuthenticatorPro.WearOS.List
{
    internal class CategoryListAdapter : WearableNavigationDrawerView.WearableNavigationDrawerAdapter
    {
        private readonly Context _context;
        private readonly ListCache<WearCategory> _cache;

        public CategoryListAdapter(Context context, ListCache<WearCategory> cache)
        {
            _context = context;
            _cache = cache;
        }
        
        public override Drawable GetItemDrawable(int pos)
        {
            return _context.GetDrawable(Resource.Drawable.ic_action_menu);
        }

        public override ICharSequence GetItemTextFormatted(int pos)
        {
            if(pos == 0)
                return new String(_context.GetString(Resource.String.categoryAll));
            
            var item = _cache.Get(pos - 1);

            return item == null
                ? new String("") 
                : new String(item.Name);
        }

        public override int Count => _cache.Count + 1;
    }
}