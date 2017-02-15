//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.5.96
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "545d3152d107d4e3")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Master</summary>
	[PublishedContentModel("umbMaster")]
	public partial class UmbMaster : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbMaster";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbMaster(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbMaster, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Page title: The page title overrules the name this page was given. So if the page name is "About us" the title could be "About Our Company Name".
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// Hide in navigation?: If set to "Yes", this page will be hidden from the navigation menu at the top.
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("umbHomePage")]
	public partial class UmbHomePage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbHomePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbHomePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbHomePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// AboutText
		///</summary>
		[ImplementPropertyType("aboutText")]
		public IHtmlString AboutText
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutText"); }
		}

		///<summary>
		/// About Title
		///</summary>
		[ImplementPropertyType("aboutTitle")]
		public string AboutTitle
		{
			get { return this.GetPropertyValue<string>("aboutTitle"); }
		}

		///<summary>
		/// Banner background image
		///</summary>
		[ImplementPropertyType("bannerBackgroundImage")]
		public object BannerBackgroundImage
		{
			get { return this.GetPropertyValue("bannerBackgroundImage"); }
		}

		///<summary>
		/// Banner Header
		///</summary>
		[ImplementPropertyType("bannerHeader")]
		public string BannerHeader
		{
			get { return this.GetPropertyValue<string>("bannerHeader"); }
		}

		///<summary>
		/// Banner link
		///</summary>
		[ImplementPropertyType("bannerLink")]
		public object BannerLink
		{
			get { return this.GetPropertyValue("bannerLink"); }
		}

		///<summary>
		/// Banner link text
		///</summary>
		[ImplementPropertyType("bannerLinkText")]
		public string BannerLinkText
		{
			get { return this.GetPropertyValue<string>("bannerLinkText"); }
		}

		///<summary>
		/// Banner Subheader
		///</summary>
		[ImplementPropertyType("bannerSubheader")]
		public string BannerSubheader
		{
			get { return this.GetPropertyValue<string>("bannerSubheader"); }
		}

		///<summary>
		/// Byline
		///</summary>
		[ImplementPropertyType("byline")]
		public string Byline
		{
			get { return this.GetPropertyValue<string>("byline"); }
		}

		///<summary>
		/// Copyright
		///</summary>
		[ImplementPropertyType("copyright")]
		public string Copyright
		{
			get { return this.GetPropertyValue<string>("copyright"); }
		}

		///<summary>
		/// Dribbble link
		///</summary>
		[ImplementPropertyType("dribbbleLink")]
		public string DribbbleLink
		{
			get { return this.GetPropertyValue<string>("dribbbleLink"); }
		}

		///<summary>
		/// Facebook link
		///</summary>
		[ImplementPropertyType("facebookLink")]
		public string FacebookLink
		{
			get { return this.GetPropertyValue<string>("facebookLink"); }
		}

		///<summary>
		/// Google+ link
		///</summary>
		[ImplementPropertyType("googleLink")]
		public string GoogleLink
		{
			get { return this.GetPropertyValue<string>("googleLink"); }
		}

		///<summary>
		/// Hide banner?
		///</summary>
		[ImplementPropertyType("hideBanner")]
		public bool HideBanner
		{
			get { return this.GetPropertyValue<bool>("hideBanner"); }
		}

		///<summary>
		/// LinkedIn link
		///</summary>
		[ImplementPropertyType("linkedInLink")]
		public string LinkedInLink
		{
			get { return this.GetPropertyValue<string>("linkedInLink"); }
		}

		///<summary>
		/// Rss link
		///</summary>
		[ImplementPropertyType("rssLink")]
		public string RssLink
		{
			get { return this.GetPropertyValue<string>("rssLink"); }
		}

		///<summary>
		/// Site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}

		///<summary>
		/// Twitter link
		///</summary>
		[ImplementPropertyType("twitterLink")]
		public string TwitterLink
		{
			get { return this.GetPropertyValue<string>("twitterLink"); }
		}
	}

	/// <summary>News Item</summary>
	[PublishedContentModel("umbNewsItem")]
	public partial class UmbNewsItem : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbNewsItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbNewsItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbNewsItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public object Image
		{
			get { return this.GetPropertyValue("image"); }
		}

		///<summary>
		/// Publish date: You can overrule the date shown on the site by changing it here. If you don't set a date explicitly here then the news item's create date will be shown.
		///</summary>
		[ImplementPropertyType("publishDate")]
		public DateTime PublishDate
		{
			get { return this.GetPropertyValue<DateTime>("publishDate"); }
		}

		///<summary>
		/// Subheader
		///</summary>
		[ImplementPropertyType("subheader")]
		public string Subheader
		{
			get { return this.GetPropertyValue<string>("subheader"); }
		}
	}

	/// <summary>News Overview</summary>
	[PublishedContentModel("umbNewsOverview")]
	public partial class UmbNewsOverview : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbNewsOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbNewsOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbNewsOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Text Page</summary>
	[PublishedContentModel("umbTextPage")]
	public partial class UmbTextPage : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbTextPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbTextPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbTextPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public IHtmlString BodyText
		{
			get { return this.GetPropertyValue<IHtmlString>("bodyText"); }
		}

		///<summary>
		/// Featured Page?: Is this a page that should be featured on the home page?
		///</summary>
		[ImplementPropertyType("featuredPage")]
		public bool FeaturedPage
		{
			get { return this.GetPropertyValue<bool>("featuredPage"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public object Image
		{
			get { return this.GetPropertyValue("image"); }
		}
	}

	/// <summary>ezSearch</summary>
	[PublishedContentModel("ezSearch")]
	public partial class EzSearch : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ezSearch";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public EzSearch(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<EzSearch, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide page?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Property Overview</summary>
	[PublishedContentModel("umbPropertyOverview")]
	public partial class UmbPropertyOverview : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbPropertyOverview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbPropertyOverview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbPropertyOverview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Property Details</summary>
	[PublishedContentModel("umbPropertyDetails")]
	public partial class UmbPropertyDetails : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbPropertyDetails";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbPropertyDetails(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbPropertyDetails, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Address2
		///</summary>
		[ImplementPropertyType("address2")]
		public string Address2
		{
			get { return this.GetPropertyValue<string>("address2"); }
		}

		///<summary>
		/// Address3: Town
		///</summary>
		[ImplementPropertyType("address3")]
		public string Address3
		{
			get { return this.GetPropertyValue<string>("address3"); }
		}

		///<summary>
		/// Address4: County
		///</summary>
		[ImplementPropertyType("address4")]
		public string Address4
		{
			get { return this.GetPropertyValue<string>("address4"); }
		}

		///<summary>
		/// Address Name: Building Name
		///</summary>
		[ImplementPropertyType("addressName")]
		public string AddressName
		{
			get { return this.GetPropertyValue<string>("addressName"); }
		}

		///<summary>
		/// Address Number: Building Number
		///</summary>
		[ImplementPropertyType("addressNumber")]
		public string AddressNumber
		{
			get { return this.GetPropertyValue<string>("addressNumber"); }
		}

		///<summary>
		/// Address Postcode: Full Postcode
		///</summary>
		[ImplementPropertyType("addressPostcode")]
		public string AddressPostcode
		{
			get { return this.GetPropertyValue<string>("addressPostcode"); }
		}

		///<summary>
		/// Address Street: Street
		///</summary>
		[ImplementPropertyType("addressStreet")]
		public string AddressStreet
		{
			get { return this.GetPropertyValue<string>("addressStreet"); }
		}

		///<summary>
		/// Availability: Residential Sales: The availability of the property for example For Sale or Sold STC. It is a numeric value which corresponds to the lookups below: 1 = On Hold 2 = For Sale 3 = Under Offer 4 = Sold STC 5 = Sold 7 = Withdrawn
		///</summary>
		[ImplementPropertyType("availability")]
		public int Availability
		{
			get { return this.GetPropertyValue<int>("availability"); }
		}

		///<summary>
		/// BranchID: Unique office ID
		///</summary>
		[ImplementPropertyType("branchID")]
		public string BranchID
		{
			get { return this.GetPropertyValue<string>("branchID"); }
		}

		///<summary>
		/// Branch Name: The branch name
		///</summary>
		[ImplementPropertyType("branchName")]
		public string BranchName
		{
			get { return this.GetPropertyValue<string>("branchName"); }
		}

		///<summary>
		/// Brochures: Property Brochures
		///</summary>
		[ImplementPropertyType("brochures")]
		public string Brochures
		{
			get { return this.GetPropertyValue<string>("brochures"); }
		}

		///<summary>
		/// Country: Country
		///</summary>
		[ImplementPropertyType("country")]
		public string Country
		{
			get { return this.GetPropertyValue<string>("country"); }
		}

		///<summary>
		/// Date Last Modified: The last date that anything happened on the property. This can be used to determine whether you need to process the property at all.
		///</summary>
		[ImplementPropertyType("dateLastModified")]
		public string DateLastModified
		{
			get { return this.GetPropertyValue<string>("dateLastModified"); }
		}

		///<summary>
		/// Department: Sales, Lettings, Commercial or Agricultural
		///</summary>
		[ImplementPropertyType("department")]
		public object Department
		{
			get { return this.GetPropertyValue("department"); }
		}

		///<summary>
		/// Development Opportunity: Property has been marked as a Development Opportunity.
		///</summary>
		[ImplementPropertyType("developmentOpportunity")]
		public bool DevelopmentOpportunity
		{
			get { return this.GetPropertyValue<bool>("developmentOpportunity"); }
		}

		///<summary>
		/// Display Address: The address to display to to the public
		///</summary>
		[ImplementPropertyType("displayAddress")]
		public string DisplayAddress
		{
			get { return this.GetPropertyValue<string>("displayAddress"); }
		}

		///<summary>
		/// Display Property Type: The property type the agent wishes to display to the public
		///</summary>
		[ImplementPropertyType("displayPropertyType")]
		public string DisplayPropertyType
		{
			get { return this.GetPropertyValue<string>("displayPropertyType"); }
		}

		///<summary>
		/// Epc Graphs: Property EPC Graph
		///</summary>
		[ImplementPropertyType("epcGraphs")]
		public string EpcGraphs
		{
			get { return this.GetPropertyValue<string>("epcGraphs"); }
		}

		///<summary>
		/// Estimated Rental Income: Contains the estimated rental value of the property per calendar month. If none is entered, the default value will be 0.
		///</summary>
		[ImplementPropertyType("estimatedRentalIncome")]
		public string EstimatedRentalIncome
		{
			get { return this.GetPropertyValue<string>("estimatedRentalIncome"); }
		}

		///<summary>
		/// Featured Property: Has the property been set as ‘Featured’ by the agent. Useful if implementing a ‘Featured Property’ section of a website.
		///</summary>
		[ImplementPropertyType("featuredProperty")]
		public bool FeaturedProperty
		{
			get { return this.GetPropertyValue<bool>("featuredProperty"); }
		}

		///<summary>
		/// Flags: Agent-specific list of property flags
		///</summary>
		[ImplementPropertyType("flags")]
		public string Flags
		{
			get { return this.GetPropertyValue<string>("flags"); }
		}

		///<summary>
		/// Floor Area: The total area of the property in the units specified below
		///</summary>
		[ImplementPropertyType("floorArea")]
		public string FloorArea
		{
			get { return this.GetPropertyValue<string>("floorArea"); }
		}

		///<summary>
		/// Floorplans: Property Floorplan
		///</summary>
		[ImplementPropertyType("floorplans")]
		public string Floorplans
		{
			get { return this.GetPropertyValue<string>("floorplans"); }
		}

		///<summary>
		/// For Sale POA: Price on application flag. If set to 1 the price should not be displayed to the public.  Values: 0=Display Price 1=Hide price
		///</summary>
		[ImplementPropertyType("forSalePOA")]
		public bool ForSalePoa
		{
			get { return this.GetPropertyValue<bool>("forSalePOA"); }
		}

		///<summary>
		/// Full Description: This is a long description and may contain basic HTML such as STRONG tags. It is usually used for the more details page and typically includes a room by room breakdown of the property
		///</summary>
		[ImplementPropertyType("fullDescription")]
		public IHtmlString FullDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("fullDescription"); }
		}

		///<summary>
		/// Images: Property Images
		///</summary>
		[ImplementPropertyType("images")]
		public string Images
		{
			get { return this.GetPropertyValue<string>("images"); }
		}

		///<summary>
		/// Investment Opportunity: Property has been marked as an Investment Opportunity.
		///</summary>
		[ImplementPropertyType("investmentOpportunity")]
		public bool InvestmentOpportunity
		{
			get { return this.GetPropertyValue<bool>("investmentOpportunity"); }
		}

		///<summary>
		/// Latitude: Latitudinal co-ordinate of property
		///</summary>
		[ImplementPropertyType("latitude")]
		public string Latitude
		{
			get { return this.GetPropertyValue<string>("latitude"); }
		}

		///<summary>
		/// Let Availbility: The availability of the property for example To Let and Let. 1 = On Hold 2 = To Let 3 = References Pending 4 = Let Agreed 5 = Let 6 = Withdrawn
		///</summary>
		[ImplementPropertyType("letAvailbility")]
		public int LetAvailbility
		{
			get { return this.GetPropertyValue<int>("letAvailbility"); }
		}

		///<summary>
		/// Longitude: Longitudinal co-ordinate of property
		///</summary>
		[ImplementPropertyType("longitude")]
		public string Longitude
		{
			get { return this.GetPropertyValue<string>("longitude"); }
		}

		///<summary>
		/// Main Summary: This is typically 300 characters long and should not contain HTML. It is usually used for the search results summary.
		///</summary>
		[ImplementPropertyType("mainSummary")]
		public string MainSummary
		{
			get { return this.GetPropertyValue<string>("mainSummary"); }
		}

		///<summary>
		/// Price: The price of the property in pounds (eg. 345000)
		///</summary>
		[ImplementPropertyType("price")]
		public int Price
		{
			get { return this.GetPropertyValue<int>("price"); }
		}

		///<summary>
		/// Price Qualifier: Text to be displayed with property price to indicate special selling conditions such as Sale by auction. It is a numeric value which corresponds to the lookups below: 1 = Asking Price Of 2 = Fixed Price 3 = From 4 = Guide Price 5 = Offers In Region Of 6 = Offers Over 7 = Auction Guide Price 8 = Sale By Tender 9 = Shared Ownership 10 = Offers In Excess Of 11 = Offers Invited 12 = Starting Bid
		///</summary>
		[ImplementPropertyType("priceQualifier")]
		public int PriceQualifier
		{
			get { return this.GetPropertyValue<int>("priceQualifier"); }
		}

		///<summary>
		/// Property Age: The property age is a numeric value which corresponds to the lookups below: 0 = Not Specified 1 = New Build 2 = Modern 3 = 1980s to 1990s 4 = 1950s, 1960s and 1970s 5 = 1940s 6 = 1920s to 1930s 7 = Edwardian (1901 - 1910) 8 = Victorian (1837 - 1901) 9 = Georgian (1714 - 1830) 10 = Pre 18th Century
		///</summary>
		[ImplementPropertyType("propertyAge")]
		public string PropertyAge
		{
			get { return this.GetPropertyValue<string>("propertyAge"); }
		}

		///<summary>
		/// Property Bathrooms: The number of bathrooms
		///</summary>
		[ImplementPropertyType("propertyBathrooms")]
		public string PropertyBathrooms
		{
			get { return this.GetPropertyValue<string>("propertyBathrooms"); }
		}

		///<summary>
		/// Property Bedrooms: The number of bedrooms
		///</summary>
		[ImplementPropertyType("propertyBedrooms")]
		public string PropertyBedrooms
		{
			get { return this.GetPropertyValue<string>("propertyBedrooms"); }
		}

		///<summary>
		/// Property Ensuites: The number of ensuites
		///</summary>
		[ImplementPropertyType("propertyEnsuites")]
		public string PropertyEnsuites
		{
			get { return this.GetPropertyValue<string>("propertyEnsuites"); }
		}

		///<summary>
		/// Property Feature 1: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature1")]
		public string PropertyFeature1
		{
			get { return this.GetPropertyValue<string>("propertyFeature1"); }
		}

		///<summary>
		/// Property Feature 10: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature10")]
		public string PropertyFeature10
		{
			get { return this.GetPropertyValue<string>("propertyFeature10"); }
		}

		///<summary>
		/// Property Feature 2: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature2")]
		public string PropertyFeature2
		{
			get { return this.GetPropertyValue<string>("propertyFeature2"); }
		}

		///<summary>
		/// Property Feature 3: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature3")]
		public string PropertyFeature3
		{
			get { return this.GetPropertyValue<string>("propertyFeature3"); }
		}

		///<summary>
		/// Property Feature 4: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature4")]
		public string PropertyFeature4
		{
			get { return this.GetPropertyValue<string>("propertyFeature4"); }
		}

		///<summary>
		/// Property Feature 6: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature6")]
		public string PropertyFeature6
		{
			get { return this.GetPropertyValue<string>("propertyFeature6"); }
		}

		///<summary>
		/// Property Feature 7: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature7")]
		public string PropertyFeature7
		{
			get { return this.GetPropertyValue<string>("propertyFeature7"); }
		}

		///<summary>
		/// Property Feature 8: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature8")]
		public string PropertyFeature8
		{
			get { return this.GetPropertyValue<string>("propertyFeature8"); }
		}

		///<summary>
		/// Property Feature 9: features of the property entered by the agent
		///</summary>
		[ImplementPropertyType("propertyFeature9")]
		public string PropertyFeature9
		{
			get { return this.GetPropertyValue<string>("propertyFeature9"); }
		}

		///<summary>
		/// PropertyID: Unique property identifier.
		///</summary>
		[ImplementPropertyType("propertyID")]
		public string PropertyID
		{
			get { return this.GetPropertyValue<string>("propertyID"); }
		}

		///<summary>
		/// Property Kitchens: The number of kitchens
		///</summary>
		[ImplementPropertyType("propertyKitchens")]
		public string PropertyKitchens
		{
			get { return this.GetPropertyValue<string>("propertyKitchens"); }
		}

		///<summary>
		/// Property Reception Rooms: The number of reception rooms
		///</summary>
		[ImplementPropertyType("propertyReceptionRooms")]
		public string PropertyReceptionRooms
		{
			get { return this.GetPropertyValue<string>("propertyReceptionRooms"); }
		}

		///<summary>
		/// Property Style: A property style lookup (eg. Detached).
		///</summary>
		[ImplementPropertyType("propertyStyle")]
		public string PropertyStyle
		{
			get { return this.GetPropertyValue<string>("propertyStyle"); }
		}

		///<summary>
		/// Property Tenure: Indicates the tenure of the property. It is a numeric value which corresponds to the lookups below. 0 = Not Specified 1 = Freehold 2 = Leasehold 3 = Commonhold 4 = Share of Freehold 5 = Flying Freehold 6 = Share Transfer 7 = Unknown
		///</summary>
		[ImplementPropertyType("propertyTenure")]
		public int PropertyTenure
		{
			get { return this.GetPropertyValue<int>("propertyTenure"); }
		}

		///<summary>
		/// Property Type: A property type lookup (eg House).  1 Houses  2 Flats / Apartments  3 Bungalows  4 Other
		///</summary>
		[ImplementPropertyType("propertyType")]
		public string PropertyType
		{
			get { return this.GetPropertyValue<string>("propertyType"); }
		}

		///<summary>
		/// Reference Number: Agents own reference
		///</summary>
		[ImplementPropertyType("referenceNumber")]
		public string ReferenceNumber
		{
			get { return this.GetPropertyValue<string>("referenceNumber"); }
		}

		///<summary>
		/// Region ID: Match Areas - Residential Sales 1 = PE13 Wisbech 3 = PE14 5 = PE15 March 7 = PE16 Chatteris 9 = PE26 11 = CB5 13 = PE7 17 = PE28 25 = CB7 31 = CB6
		///</summary>
		[ImplementPropertyType("regionID")]
		public int RegionID
		{
			get { return this.GetPropertyValue<int>("regionID"); }
		}

		///<summary>
		/// Rent: The rent of the property in pounds
		///</summary>
		[ImplementPropertyType("rent")]
		public string Rent
		{
			get { return this.GetPropertyValue<string>("rent"); }
		}

		///<summary>
		/// Rent Frequency: The rent frequency of the property such as Per Calendar Month 1 = pcm 2 = pw 3 = pa
		///</summary>
		[ImplementPropertyType("rentFrequency")]
		public int RentFrequency
		{
			get { return this.GetPropertyValue<int>("rentFrequency"); }
		}

		///<summary>
		/// Sale By: Indicates type of sale on the property. It is a numeric value which corresponds to the lookups below.  0 = Not Specified 1 = Private Treaty 2 = By Auction 3 = Confidential 4 = By Tender 5 = Offers Invited
		///</summary>
		[ImplementPropertyType("saleBy")]
		public int SaleBy
		{
			get { return this.GetPropertyValue<int>("saleBy"); }
		}

		///<summary>
		/// Student Property: Will be equal to ‘1’ this property has a let type of ‘Student’
		///</summary>
		[ImplementPropertyType("studentProperty")]
		public bool StudentProperty
		{
			get { return this.GetPropertyValue<bool>("studentProperty"); }
		}

		///<summary>
		/// Time Last Modified: The time that anything last happened on the property, this can be combined with the dateLastModified to create an accurate datetime. This can be used to determine whether you need to process the property at all.
		///</summary>
		[ImplementPropertyType("timeLastModified")]
		public string TimeLastModified
		{
			get { return this.GetPropertyValue<string>("timeLastModified"); }
		}

		///<summary>
		/// To Let POA: Rent on application flag. If set to 1 the rent should not be displayed to the public.  0 = Display Price 1 = Hide price
		///</summary>
		[ImplementPropertyType("toLetPOA")]
		public int ToLetPoa
		{
			get { return this.GetPropertyValue<int>("toLetPOA"); }
		}
	}

	/// <summary>Property Details Lettings</summary>
	[PublishedContentModel("umbPropertyDetailsLettings")]
	public partial class UmbPropertyDetailsLettings : UmbMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbPropertyDetailsLettings";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbPropertyDetailsLettings(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbPropertyDetailsLettings, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Property ID
		///</summary>
		[ImplementPropertyType("propertyID")]
		public string PropertyID
		{
			get { return this.GetPropertyValue<string>("propertyID"); }
		}

		///<summary>
		/// Rent
		///</summary>
		[ImplementPropertyType("rent")]
		public string Rent
		{
			get { return this.GetPropertyValue<string>("rent"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
