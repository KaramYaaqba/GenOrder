using GenOrder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Xml;
namespace GenOrder {


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Load all classes from the Models folder namespace
        var modelTypes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.Namespace != "GenOrder" && t.IsClass && !t.IsAbstract);

        foreach (var type in modelTypes)
        {
            try
            {
                var entityTypeBuilder = modelBuilder.Entity(type);

if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("NettedTransactionSummary");
            }

            if (type == typeof(AdFormatLeadType))
            {
                entityTypeBuilder.Ignore("Address");
            }

            if (type == typeof(AddDisputeRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AccountEntryType))
            {
                entityTypeBuilder.Ignore("Balance");
            }
            
            if (type == typeof(AccountEntryType))
            {
                entityTypeBuilder.Ignore("ConversionRate");
            }
                    
            if (type == typeof(AccountEntryType))
            {
                entityTypeBuilder.Ignore("GrossDetailAmount");
            }
                            
            if (type == typeof(AccountEntryType))
            {
                entityTypeBuilder.Ignore("NetDetailAmount");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("AmountPastDue");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("CurrentBalance");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("InvoiceBalance");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("InvoiceCredit");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("InvoiceNewFee");
            }
            
            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("InvoicePayment");
            }
            
            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("LastAmountPaid");
            }
                    
            if (type == typeof(AdFormatLeadType))
            {
                entityTypeBuilder.Ignore("LeadFee");
            }
                            
            if (type == typeof(AddDisputeResponseRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddDisputeResponseResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddDisputeResponseResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
            
            if (type == typeof(AddDisputeResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
            
            if (type == typeof(AddDisputeResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddFixedPriceItemRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddFixedPriceItemRequestType))
            {
                entityTypeBuilder.Ignore("Item");
            }

            if (type == typeof(AddFixedPriceItemResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddFixedPriceItemResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddFixedPriceItemResponseType))
            {
                entityTypeBuilder.Ignore("ListingRecommendations");
            }

            if (type == typeof(AddFixedPriceItemResponseType))
            {
                entityTypeBuilder.Ignore("ProductSuggestions");
            }
            
            if (type == typeof(AddItemFromSellingManagerTemplateRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
                    
            if (type == typeof(AddItemFromSellingManagerTemplateRequestType))
            {
                entityTypeBuilder.Ignore("Item");
            }

            if (type == typeof(AddItemFromSellingManagerTemplateResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddItemFromSellingManagerTemplateResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddItemRequestContainerType))
            {
                entityTypeBuilder.Ignore("Item");
            }

            if (type == typeof(AddItemRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
            
            if (type == typeof(AddItemRequestType))
            {
                entityTypeBuilder.Ignore("Item");
            }

            if (type == typeof(AddItemResponseContainerType))
            {
                entityTypeBuilder.Ignore("ListingRecommendations");
            }

            
            if (type == typeof(AddItemResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
        
            if (type == typeof(AddItemResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
                    
            if (type == typeof(AddItemResponseType))
            {
                entityTypeBuilder.Ignore("ListingRecommendations");
            }

                            
            if (type == typeof(AddItemResponseType))
            {
                entityTypeBuilder.Ignore("ProductSuggestions");
            }

                                    
            if (type == typeof(AddItemsRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

                                            
            if (type == typeof(AddItemsResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
                                                    
            if (type == typeof(AddItemsResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
                                                            

                entityTypeBuilder.Ignore("BotBlock");
            

            if (type == typeof(AddMemberMessageAAQToPartnerRequestType))
            {
                entityTypeBuilder.Ignore("MemberMessage");
            }

            if (type == typeof(AddMemberMessageAAQToPartnerResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddMemberMessageRTQRequestType))
            {
                entityTypeBuilder.Ignore("MemberMessage");
            }

            if (type == typeof(AddMemberMessageRTQResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddMemberMessagesAAQToBidderRequestContainerType))
            {
                entityTypeBuilder.Ignore("MemberMessage");
            }

            if (type == typeof(AddMemberMessagesAAQToBidderResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddOrderRequestType))
            {
                entityTypeBuilder.Ignore("Order");
            }

            if (type == typeof(AddOrderResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
            
            if (type == typeof(AddSecondChanceItemRequestType))
            {
                entityTypeBuilder.Ignore("BuyItNowPrice");
            }

                    
            if (type == typeof(AddSecondChanceItemResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

                            
            if (type == typeof(AddSellingManagerInventoryFolderResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddSellingManagerProductRequestType))
            {
                entityTypeBuilder.Ignore("SellingManagerProductDetails");
            }
            
            if (type == typeof(AddSellingManagerProductRequestType))
            {
                entityTypeBuilder.Ignore("SellingManagerProductSpecifics");
            }

                    
            if (type == typeof(AddSellingManagerProductResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

                            
            if (type == typeof(AddSellingManagerProductResponseType))
            {
                entityTypeBuilder.Ignore("SellingManagerProductDetails");
            }

                                    
            if (type == typeof(AddSellingManagerTemplateRequestType))
            {
                entityTypeBuilder.Ignore("Item");
            }

                                            
            if (type == typeof(AddSellingManagerTemplateResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

                                                    
            if (type == typeof(AddSellingManagerTemplateResponseType))
            {
                entityTypeBuilder.Ignore("SellingManagerProductDetails");
            }
                                                                
            if (type == typeof(AddToItemDescriptionResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddToItemDescriptionResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
            
            if (type == typeof(AddToWatchListResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
                        
            if (type == typeof(AddTransactionConfirmationItemRequestType))
            {
                entityTypeBuilder.Ignore("NegotiatedPrice");
            }
                                    
            if (type == typeof(AddTransactionConfirmationItemResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
                // Check if the current type has a property that can be used as a primary key
                var hasKey = type.GetProperties()
                    .Any(p => p.Name.Equals("Id", StringComparison.OrdinalIgnoreCase) ||
                              p.Name.Equals($"{type.Name}Id", StringComparison.OrdinalIgnoreCase));

                if (!hasKey)
                {
                    // If no primary key is found, mark the entity as keyless
                    entityTypeBuilder.HasNoKey();
                }

                // Ignore unsupported types like XmlElement or complex navigation properties
                var properties = type.GetProperties();
                foreach (var property in properties)
                {
                    var propertyType = property.PropertyType;

                    if (propertyType == typeof(System.Xml.XmlElement) ||
                        propertyType == typeof(System.Xml.XmlElement[]) ||
                        propertyType.IsSubclassOf(typeof(System.Xml.XmlNode)) ||
                        propertyType == typeof(XmlDocument) )
                    {
                        entityTypeBuilder.Ignore(property.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error configuring entity '{type.Name}': {ex.Message}");
            }
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
}
}
/*
    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // Load all types in the GenOrder namespace
    var modelTypes = Assembly.GetExecutingAssembly().GetTypes()
        .Where(t => t.Namespace == "GenOrder" && t.IsClass && !t.IsAbstract);

    foreach (var type in modelTypes)
    {
            var entityTypeBuilder = modelBuilder.Entity(type);

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("NettedTransactionSummary");
            }

            if (type == typeof(AdFormatLeadType))
            {
                entityTypeBuilder.Ignore("Address");
            }

            if (type == typeof(AddDisputeRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AccountEntryType))
            {
                entityTypeBuilder.Ignore("Balance");
            }
            
            if (type == typeof(AccountEntryType))
            {
                entityTypeBuilder.Ignore("ConversionRate");
            }
                    
            if (type == typeof(AccountEntryType))
            {
                entityTypeBuilder.Ignore("GrossDetailAmount");
            }
                            
            if (type == typeof(AccountEntryType))
            {
                entityTypeBuilder.Ignore("NetDetailAmount");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("AmountPastDue");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("CurrentBalance");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("InvoiceBalance");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("InvoiceCredit");
            }

            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("InvoiceNewFee");
            }
            
            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("InvoicePayment");
            }
            
            if (type == typeof(AccountSummaryType))
            {
                entityTypeBuilder.Ignore("LastAmountPaid");
            }
                    
            if (type == typeof(AdFormatLeadType))
            {
                entityTypeBuilder.Ignore("LeadFee");
            }
                            
            if (type == typeof(AddDisputeResponseRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddDisputeResponseResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddDisputeResponseResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
            
            if (type == typeof(AddDisputeResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
            
            if (type == typeof(AddDisputeResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddFixedPriceItemRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddFixedPriceItemRequestType))
            {
                entityTypeBuilder.Ignore("Item");
            }

            if (type == typeof(AddFixedPriceItemResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddFixedPriceItemResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddFixedPriceItemResponseType))
            {
                entityTypeBuilder.Ignore("ListingRecommendations");
            }

            if (type == typeof(AddFixedPriceItemResponseType))
            {
                entityTypeBuilder.Ignore("ProductSuggestions");
            }
            
            if (type == typeof(AddItemFromSellingManagerTemplateRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
                    
            if (type == typeof(AddItemFromSellingManagerTemplateRequestType))
            {
                entityTypeBuilder.Ignore("Item");
            }

            if (type == typeof(AddItemFromSellingManagerTemplateResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

            if (type == typeof(AddItemFromSellingManagerTemplateResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddItemRequestContainerType))
            {
                entityTypeBuilder.Ignore("Item");
            }

            if (type == typeof(AddItemRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
            
            if (type == typeof(AddItemRequestType))
            {
                entityTypeBuilder.Ignore("Item");
            }

            if (type == typeof(AddItemResponseContainerType))
            {
                entityTypeBuilder.Ignore("ListingRecommendations");
            }

            
            if (type == typeof(AddItemResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
        
            if (type == typeof(AddItemResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
                    
            if (type == typeof(AddItemResponseType))
            {
                entityTypeBuilder.Ignore("ListingRecommendations");
            }

                            
            if (type == typeof(AddItemResponseType))
            {
                entityTypeBuilder.Ignore("ProductSuggestions");
            }

                                    
            if (type == typeof(AddItemsRequestType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }

                                            
            if (type == typeof(AddItemsResponseType))
            {
                entityTypeBuilder.Ignore("BotBlock");
            }
                                                    
            if (type == typeof(AddItemsResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
                                                            

                entityTypeBuilder.Ignore("BotBlock");
            

            if (type == typeof(AddMemberMessageAAQToPartnerRequestType))
            {
                entityTypeBuilder.Ignore("MemberMessage");
            }

            if (type == typeof(AddMemberMessageAAQToPartnerResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddMemberMessageRTQRequestType))
            {
                entityTypeBuilder.Ignore("MemberMessage");
            }

            if (type == typeof(AddMemberMessageRTQResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddMemberMessagesAAQToBidderRequestContainerType))
            {
                entityTypeBuilder.Ignore("MemberMessage");
            }

            if (type == typeof(AddMemberMessagesAAQToBidderResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddOrderRequestType))
            {
                entityTypeBuilder.Ignore("Order");
            }

            if (type == typeof(AddOrderResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
            
            if (type == typeof(AddSecondChanceItemRequestType))
            {
                entityTypeBuilder.Ignore("BuyItNowPrice");
            }

                    
            if (type == typeof(AddSecondChanceItemResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

                            
            if (type == typeof(AddSellingManagerInventoryFolderResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddSellingManagerProductRequestType))
            {
                entityTypeBuilder.Ignore("SellingManagerProductDetails");
            }
            
            if (type == typeof(AddSellingManagerProductRequestType))
            {
                entityTypeBuilder.Ignore("SellingManagerProductSpecifics");
            }

                    
            if (type == typeof(AddSellingManagerProductResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

                            
            if (type == typeof(AddSellingManagerProductResponseType))
            {
                entityTypeBuilder.Ignore("SellingManagerProductDetails");
            }

                                    
            if (type == typeof(AddSellingManagerTemplateRequestType))
            {
                entityTypeBuilder.Ignore("Item");
            }

                                            
            if (type == typeof(AddSellingManagerTemplateResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

                                                    
            if (type == typeof(AddSellingManagerTemplateResponseType))
            {
                entityTypeBuilder.Ignore("SellingManagerProductDetails");
            }
                                                                
            if (type == typeof(AddToItemDescriptionResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }

            if (type == typeof(AddToItemDescriptionResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
            
            if (type == typeof(AddToWatchListResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
                        
            if (type == typeof(AddTransactionConfirmationItemRequestType))
            {
                entityTypeBuilder.Ignore("NegotiatedPrice");
            }
                                    
            if (type == typeof(AddTransactionConfirmationItemResponseType))
            {
                entityTypeBuilder.Ignore("DuplicateInvocationDetails");
            }
            // Check if the type is derived from AmountType
            var baseType = type.BaseType;
            if (baseType != null && baseType == typeof(AmountType))
            {
                // You might want to exclude derived types from the model if the base type is problematic
                continue;
            }

            

            // Check if the current type has a property that can be used as a primary key
            var hasKey = type.GetProperties()
                .Any(p => p.Name.Equals("Id", StringComparison.OrdinalIgnoreCase) ||
                        p.Name.Equals($"{type.Name}Id", StringComparison.OrdinalIgnoreCase));

            if (!hasKey)
            {
                // If no primary key is found, mark the entity as keyless
                entityTypeBuilder.HasNoKey();
            }

            // Ignore XmlElement and similar unsupported types
            var properties = type.GetProperties();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(System.Xml.XmlElement) || property.PropertyType == typeof(System.Xml.XmlElement[]))
                {
                    entityTypeBuilder.Ignore(property.Name); // Provide the property name here
                }
            }
    }
}
*/