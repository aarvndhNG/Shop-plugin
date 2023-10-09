using System.Collections.Generic;

namespace ShopPlugin
{
    class Lang
    {
        private static string _buyCommand = "buy";
        private static string _listItemCommand = "list";
        private static string _buyItemPermission = "shop.buy";
        private static string _sellCommand = "sell";
        private static string _sellItemPermission = "shop.sell";
        private static string _shopCommand = "shop";
        private static string _shopPermission = "shop.shop";    
        private static string _searchCommand = "search";
        private static string _searchPermission = "shop.search";
        private static string _shopRegionName = "Shop";

        private static Dictionary<string, string> _message = new Dictionary<string, string>
        {
            {"Load", "[c/00FF00:Loaded {0} items in shop]"},
            {"NoPerms", "[c/FF0000:You cannot use this command.]"},
            {"BuyInfo", "[c/00FF00:/{0} {1} (Item index/name) [Quantity] - buy an item depending on its index/name]"},
            {"SellInfo", "[c/00FF00:/{0} {1} - sell whats in your selected slot in the hotbar.]"},
            {"ListItems", "[c/00FF00:/{0} {1} - list items presently in the shop.]"},
            {"SearchInfo", "/{0} {1} Optional:(Item ID/name) - searches if an item from either its id/name or from what you have selected in your hotbar is in the shop and gives you its prices/index."},
            {"NoSlot", "There is no room in your inventory!" },
            {"TooMany", "We only have [c/{0}:{1}] [i:{2}]."},
            {"OnBuy", "[c/{0}:Purchase was successfull!] You bought [c/{1}:{2}] [i/p{3}:{4}] for {5}, you have {6} left in your bank."},
            {"OnSell", "[c/{0}:Sale was successfull!] You sold [c/{1}:{2}] [i/p{3}:{4}] for {5}, you now have {6} in your bank."},
            {"EmptyHand", "Select an item in your hotbar, then type /{0} {1}"},
            {"WrongSellItem", "We can't buy this item" },
            {"Error", "[c/FF0000:Something went wrong!]" },
            {"NoMatch", "We don't have that in stock!" },
            {"SearchItem", " - {0} [{1}] - [c/{2}:{3}]([c/{4}:{5}]) [c/{6}:B:] {7} {8}" },
            {"NotInShop", "You must be in the area of the counter to use the shop." },
            {"ShopCommands", "Shop Commands:" },
            {"NoMoney", "You don't have enough money! You are missing: {0}"}
        };

        public static Config DefaultConfig()
        {
            Config vConf = new Config
            {
                BuyCommand = _buyCommand,
                BuyItemPermission = _buyItemPermission,
                ListShopItemsCommand = _listItemCommand,
                SellCommand = _sellCommand,
                SellItemPermission = _sellItemPermission,
                ShopCommand = _shopCommand,
                ShopPermission = _shopPermission,
                SearchCommand = _searchCommand,
                SearchPermission = _searchPermission,
                ShopRegionName = _shopRegionName,
                Tip = "You can find Id and Names off all terraria items there: https://terraria.fandom.com/wiki/Item_IDs",
                Messages = _message,

                //for example
                Items = new List<ItemInfo>()
                {
                    new ItemInfo
                    {
                        Id = 19,
                        Name = Terraria.Lang.GetItemNameValue(19),
                        Infinity = false,
                        Amount = 500,

                        SelPrice = "1000",
                        BuyPrice = "2000"
                    },
                    new ItemInfo
                    {
                        Id = 46,
                        Name = Terraria.Lang.GetItemNameValue(46),
                        modifierId = 40,
                        Infinity = false,
                        Amount = 500,
                        SelPrice = "0",
                        BuyPrice = "1000"
                    },
                    new ItemInfo
                    {
                        Id = 21,
                        Name = Terraria.Lang.GetItemNameValue(21),
                        Infinity = false,
                        Amount = 500,
                        SelPrice = "750",
                        BuyPrice = "1500"
                    }
                }
            };
            return vConf;
        }
    }
}
