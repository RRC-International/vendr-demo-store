//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
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

namespace Vendr.DemoStore.Models
{
	/// <summary>Page</summary>
	[PublishedModel("page")]
	public partial class Page : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "page";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Page, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Page(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Meta Description: Appears in Google search results. It should be descriptive and in complete sentences. Include value statements and a call-to-action (click here, learn more by clicking here, download here, view video, etc) so people click the link. Include relevant keywords. 50-155 characters.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => this.Value<string>("metaDescription");

		///<summary>
		/// Meta Image: Used mostly by social media services such as Twitter and Facebook. The image that should be displayed as a preview for this page. If one is not defined one will try to be worked out from the pages content where possible.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaImage")]
		public IPublishedContent MetaImage => this.Value<IPublishedContent>("metaImage");

		///<summary>
		/// Meta Keywords: Used by smaller search engines but not Google, Bing or Yahoo. The meta keywords to display to search engines. List in order of relevance and importance. Separate words or phrases with a comma. Include misspellings and variations. Include action words such as buy, shop, find, download or words related to your industry.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords => this.Value<string>("metaKeywords");

		///<summary>
		/// Page Title: Overrides the default page title.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => this.Value<string>("pageTitle");

		///<summary>
		/// Raw Markup: DANGEROUS! Drop in any raw markup to be appended before the closing body tag. Used mostly for analytics code snippets. It's best not to use this field unless you know what you are doing.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("rawMarkup")]
		public string RawMarkup => this.Value<string>("rawMarkup");

		///<summary>
		/// Redirect to Node: If sets redirects any request for this page to the linked page instead.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoRedirect")]
		public IPublishedContent UmbracoRedirect => this.Value<IPublishedContent>("umbracoRedirect");

		///<summary>
		/// URL Alias: Defines a comma-separated list of alternative URLs this page should be accessible from. Good for marketing purposes.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => this.Value<string>("umbracoUrlAlias");

		///<summary>
		/// URL Name: Overrides the default URL name.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName => this.Value<string>("umbracoUrlName");
	}
}