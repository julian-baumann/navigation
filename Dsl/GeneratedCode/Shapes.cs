﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Navigation.Designer
{
	/// <summary>
	/// DomainClass StateShape
	/// Shape used to represent ExampleElements on a Diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("Navigation.Designer.StateShape.DisplayName", typeof(global::Navigation.Designer.NavigationLanguageDomainModel), "Navigation.Designer.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Navigation.Designer.StateShape.Description", typeof(global::Navigation.Designer.NavigationLanguageDomainModel), "Navigation.Designer.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Navigation.Designer.NavigationLanguageDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("9f74225c-a664-4930-a0fe-46845216068a")]
	public partial class StateShape : DslDiagrams::NodeShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with StateShape.
		/// </summary>
		public static DslDiagrams::Decorator FindStateShapeDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		
		/// <summary>
		/// Shape instance initialization.
		/// </summary>
		public override void OnInitialize()
		{
			base.OnInitialize();
			
			// Create host shapes for outer decorators.
			foreach(DslDiagrams::Decorator decorator in this.Decorators)
			{
				if(decorator.RequiresHost)
				{
					decorator.ConfigureHostShape(this);
				}
			}
			
		}
		#endregion
		#region Shape size
		
		/// <summary>
		/// Default size for this shape.
		/// </summary>
		public override DslDiagrams::SizeD DefaultSize
		{
			get
			{
				return new DslDiagrams::SizeD(2, 0.75);
			}
		}
		#endregion
		#region Shape styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Outline pen settings for this shape.
			DslDiagrams::PenSettings outlinePen = new DslDiagrams::PenSettings();
			outlinePen.Color = global::System.Drawing.Color.FromArgb(255, 113, 111, 110);
			outlinePen.Width = 0.01F;
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ShapeOutline, outlinePen);
			// Fill brush settings for this shape.
			DslDiagrams::BrushSettings backgroundBrush = new DslDiagrams::BrushSettings();
			backgroundBrush.Color = global::System.Drawing.Color.FromArgb(255, 242, 239, 229);
			classStyleSet.OverrideBrush(DslDiagrams::DiagramBrushes.ShapeBackground, backgroundBrush);
		
		}
		
		/// <summary>
		/// Indicates whether this shape displays a background gradient.
		/// </summary>
		public override bool HasBackgroundGradient
		{
			get
			{
				return true;
			}
		}
		
		/// <summary>
		/// Indicates the direction of the gradient.
		/// </summary>
		public override global::System.Drawing.Drawing2D.LinearGradientMode BackgroundGradientMode
		{
			get
			{
				return global::System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			}
		}
		#endregion
		#region Decorators
		/// <summary>
		/// Initialize the collection of shape fields associated with this shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
			DslDiagrams::TextField field1 = new DslDiagrams::TextField("KeyDecorator");
			field1.DefaultText = global::Navigation.Designer.NavigationLanguageDomainModel.SingletonResourceManager.GetString("StateShapeKeyDecoratorDefaultText");
			field1.DefaultFocusable = true;
			field1.DefaultAutoSize = true;
			field1.AnchoringBehavior.MinimumHeightInLines = 1;
			field1.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field1.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			shapeFields.Add(field1);
			
			DslDiagrams::TextField field2 = new DslDiagrams::TextField("PageDecorator");
			field2.DefaultText = global::Navigation.Designer.NavigationLanguageDomainModel.SingletonResourceManager.GetString("StateShapePageDecoratorDefaultText");
			field2.DefaultFocusable = true;
			field2.DefaultAutoSize = true;
			field2.AnchoringBehavior.MinimumHeightInLines = 1;
			field2.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field2.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			shapeFields.Add(field2);
			
			DslDiagrams::ImageField field3 = new DslDiagrams::ImageField("InitialDecorator");
			field3.DefaultImage = DslDiagrams::ImageHelper.GetImage(global::Navigation.Designer.NavigationLanguageDomainModel.SingletonResourceManager.GetObject("StateShapeInitialDecoratorDefaultImage"));
			shapeFields.Add(field3);
			
			DslDiagrams::TextField field4 = new DslDiagrams::TextField("RouteDecorator");
			field4.DefaultText = global::Navigation.Designer.NavigationLanguageDomainModel.SingletonResourceManager.GetString("StateShapeRouteDecoratorDefaultText");
			field4.DefaultFocusable = true;
			field4.DefaultAutoSize = true;
			field4.AnchoringBehavior.MinimumHeightInLines = 1;
			field4.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field4.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			shapeFields.Add(field4);
			
		}
		
		/// <summary>
		/// Initialize the collection of decorators associated with this shape type.  This method also
		/// creates shape fields for outer decorators, because these are not part of the shape fields collection
		/// associated with the shape, so they must be created here rather than in InitializeShapeFields.
		/// </summary>
		protected override void InitializeDecorators(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields, global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators)
		{
			base.InitializeDecorators(shapeFields, decorators);
			
			DslDiagrams::ShapeField field1 = DslDiagrams::ShapeElement.FindShapeField(shapeFields, "KeyDecorator");
			DslDiagrams::Decorator decorator1 = new DslDiagrams::ShapeDecorator(field1, DslDiagrams::ShapeDecoratorPosition.InnerTopCenter, DslDiagrams::PointD.Empty);
			decorators.Add(decorator1);
				
			DslDiagrams::ShapeField field2 = DslDiagrams::ShapeElement.FindShapeField(shapeFields, "PageDecorator");
			DslDiagrams::Decorator decorator2 = new DslDiagrams::ShapeDecorator(field2, DslDiagrams::ShapeDecoratorPosition.Center, DslDiagrams::PointD.Empty);
			decorators.Add(decorator2);
				
			DslDiagrams::ShapeField field3 = DslDiagrams::ShapeElement.FindShapeField(shapeFields, "InitialDecorator");
			DslDiagrams::Decorator decorator3 = new DslDiagrams::ShapeDecorator(field3, DslDiagrams::ShapeDecoratorPosition.InnerTopLeft, DslDiagrams::PointD.Empty);
			decorators.Add(decorator3);
				
			DslDiagrams::ShapeField field4 = DslDiagrams::ShapeElement.FindShapeField(shapeFields, "RouteDecorator");
			DslDiagrams::Decorator decorator4 = new DslDiagrams::ShapeDecorator(field4, DslDiagrams::ShapeDecoratorPosition.InnerBottomCenter, DslDiagrams::PointD.Empty);
			decorators.Add(decorator4);
				
		}
		
		/// <summary>
		/// Ensure outer decorators are placed appropriately.  This is called during view fixup,
		/// after the shape has been associated with the model element.
		/// </summary>
		public override void OnBoundsFixup(DslDiagrams::BoundsFixupState fixupState, int iteration, bool createdDuringViewFixup)
		{
			base.OnBoundsFixup(fixupState, iteration, createdDuringViewFixup);
			
			if(iteration == 0)
			{
				foreach(DslDiagrams::Decorator decorator in this.Decorators)
				{
					if(decorator.RequiresHost)
					{
						decorator.RepositionHostShape(decorator.GetHostShape(this));
					}
				}
			}
		}
		#endregion
		#region Constructors, domain class Id
	
		/// <summary>
		/// StateShape domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x9f74225c, 0xa664, 0x4930, 0xa0, 0xfe, 0x46, 0x84, 0x52, 0x16, 0x06, 0x8a);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public StateShape(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public StateShape(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}

