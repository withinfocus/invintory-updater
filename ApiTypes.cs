using System.Text.Json.Serialization;

public class FirebaseAuthResponse
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }

    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
}

public class Cellar
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("collection_id")]
    public int? CollectionId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

public class Collection
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("cellars")]
    public List<Cellar>? Cellars { get; set; }
}

public class ProfileResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("collection_id")]
    public int? CollectionId { get; set; }

    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }
}

public class Bottle
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("label_id")]
    public int? LabelId { get; set; }

    [JsonPropertyName("wine_id")]
    public int? WineId { get; set; }

    [JsonPropertyName("collection_id")]
    public int? CollectionId { get; set; }

    [JsonPropertyName("collections_labels_id")]
    public int? CollectionsLabelsId { get; set; }

    [JsonPropertyName("cellar_id")]
    public int? CellarId { get; set; }

    [JsonPropertyName("purchase_place")]
    public object? PurchasePlace { get; set; }

    [JsonPropertyName("purchase_price")]
    public double? PurchasePrice { get; set; }

    [JsonPropertyName("purchase_currency")]
    public string? PurchaseCurrency { get; set; }

    [JsonPropertyName("server_purchase_price")]
    public double? ServerPurchasePrice { get; set; }

    [JsonPropertyName("purchase_date")]
    public object? PurchaseDate { get; set; }

    [JsonPropertyName("from_year_drink_window")]
    public object? FromYearDrinkWindow { get; set; }

    [JsonPropertyName("to_year_drink_window")]
    public object? ToYearDrinkWindow { get; set; }

    [JsonPropertyName("bottle_size")]
    public string? BottleSize { get; set; }

    [JsonPropertyName("tasting_notes")]
    public object? TastingNotes { get; set; }

    [JsonPropertyName("personal_notes")]
    public object? PersonalNotes { get; set; }

    [JsonPropertyName("custom_bin_location")]
    public object? CustomBinLocation { get; set; }

    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    [JsonPropertyName("is_consumed")]
    public bool? IsConsumed { get; set; }

    [JsonPropertyName("consumed_at")]
    public object? ConsumedAt { get; set; }

    [JsonPropertyName("consumed_notes")]
    public object? ConsumedNotes { get; set; }

    [JsonPropertyName("removal_type")]
    public object? RemovalType { get; set; }

    [JsonPropertyName("removal_date")]
    public object? RemovalDate { get; set; }

    [JsonPropertyName("removal_note")]
    public object? RemovalNote { get; set; }

    [JsonPropertyName("in_transit")]
    public bool? InTransit { get; set; }

    [JsonPropertyName("delivery_date")]
    public object? DeliveryDate { get; set; }

    [JsonPropertyName("delivery_reminder_id")]
    public object? DeliveryReminderId { get; set; }

    [JsonPropertyName("added_by")]
    public string? AddedBy { get; set; }

    [JsonPropertyName("last_edited_by")]
    public string? LastEditedBy { get; set; }

    [JsonPropertyName("consumption_activity_id")]
    public object? ConsumptionActivityId { get; set; }

    [JsonPropertyName("location_id")]
    public object? LocationId { get; set; }

    [JsonPropertyName("delivery_id")]
    public object? DeliveryId { get; set; }

    [JsonPropertyName("barcode")]
    public string? Barcode { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("is_printed")]
    public bool? IsPrinted { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("import_bottle_id")]
    public object? ImportBottleId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("converted_purchase_price")]
    public double? ConvertedPurchasePrice { get; set; }

    [JsonPropertyName("cellar")]
    public Cellar? Cellar { get; set; }

    [JsonPropertyName("location")]
    public object? Location { get; set; }

    [JsonPropertyName("tags")]
    public List<object>? Tags { get; set; }

    [JsonPropertyName("place")]
    public object? Place { get; set; }
}

public class Label
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("label_id")]
    public int? LabelId { get; set; }

    [JsonPropertyName("collection_id")]
    public int? CollectionId { get; set; }

    [JsonPropertyName("created_by")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("name")]
    public object? Name { get; set; }

    [JsonPropertyName("from_year_drink_window")]
    public int? FromYearDrinkWindow { get; set; }

    [JsonPropertyName("to_year_drink_window")]
    public int? ToYearDrinkWindow { get; set; }

    [JsonPropertyName("abv")]
    public object? Abv { get; set; }

    [JsonPropertyName("price_average")]
    public object? PriceAverage { get; set; }

    [JsonPropertyName("price_average_usd")]
    public object? PriceAverageUsd { get; set; }

    [JsonPropertyName("price_average_currency")]
    public object? PriceAverageCurrency { get; set; }

    [JsonPropertyName("price_average_magnum")]
    public object? PriceAverageMagnum { get; set; }

    [JsonPropertyName("price_average_magnum_usd")]
    public object? PriceAverageMagnumUsd { get; set; }

    [JsonPropertyName("price_average_magnum_currency")]
    public object? PriceAverageMagnumCurrency { get; set; }

    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }

    [JsonPropertyName("assigned_to_location_at")]
    public object? AssignedToLocationAt { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("bottles")]
    public List<Bottle>? Bottles { get; set; }

    [JsonPropertyName("wine_id")]
    public int? WineId { get; set; }

    [JsonPropertyName("year")]
    public int? Year { get; set; }

    [JsonPropertyName("ws_score")]
    public int? WsScore { get; set; }

    [JsonPropertyName("back_label_image_url")]
    public object? BackLabelImageUrl { get; set; }

    [JsonPropertyName("wmj_id")]
    public int? WmjId { get; set; }

    [JsonPropertyName("bottle_image_url")]
    public string? BottleImageUrl { get; set; }

    [JsonPropertyName("wmj_price_last_fetched")]
    public DateTime? WmjPriceLastFetched { get; set; }

    [JsonPropertyName("shop_url")]
    public object? ShopUrl { get; set; }

    [JsonPropertyName("synced_to_perfect_label")]
    public object? SyncedToPerfectLabel { get; set; }

    [JsonPropertyName("ws_details_fetched")]
    public DateTime? WsDetailsFetched { get; set; }

    [JsonPropertyName("oak_type")]
    public string? OakType { get; set; }

    [JsonPropertyName("harvest")]
    public string? Harvest { get; set; }

    [JsonPropertyName("residual_sugar")]
    public double? ResidualSugar { get; set; }

    [JsonPropertyName("ageing")]
    public string? Ageing { get; set; }

    [JsonPropertyName("vintage_notes")]
    public string? VintageNotes { get; set; }

    [JsonPropertyName("winemaker")]
    public string? Winemaker { get; set; }

    [JsonPropertyName("production_volume")]
    public string? ProductionVolume { get; set; }

    [JsonPropertyName("closure")]
    public string? Closure { get; set; }

    [JsonPropertyName("ws_job_state")]
    public string? WsJobState { get; set; }

    [JsonPropertyName("price_average_converted")]
    public double? PriceAverageConverted { get; set; }

    [JsonPropertyName("collector_price_average_converted")]
    public object? CollectorPriceAverageConverted { get; set; }

    [JsonPropertyName("collector_price_average_magnum_converted")]
    public object? CollectorPriceAverageMagnumConverted { get; set; }

    [JsonPropertyName("wine")]
    public Wine? Wine { get; set; }

    [JsonPropertyName("custom_label_information")]
    public object? CustomLabelInformation { get; set; }

    [JsonPropertyName("custom_fields")]
    public List<object>? CustomFields { get; set; }

    [JsonPropertyName("collector_from_year_drink_window")]
    public object? CollectorFromYearDrinkWindow { get; set; }

    [JsonPropertyName("collector_to_year_drink_window")]
    public object? CollectorToYearDrinkWindow { get; set; }

    [JsonPropertyName("collector_image_url")]
    public object? CollectorImageUrl { get; set; }

    [JsonPropertyName("collector_thumbnail_url")]
    public object? CollectorThumbnailUrl { get; set; }

    [JsonPropertyName("collector_name")]
    public object? CollectorName { get; set; }

    [JsonPropertyName("collector_price_average")]
    public object? CollectorPriceAverage { get; set; }

    [JsonPropertyName("collector_price_average_currency")]
    public object? CollectorPriceAverageCurrency { get; set; }

    [JsonPropertyName("collector_price_average_magnum")]
    public object? CollectorPriceAverageMagnum { get; set; }

    [JsonPropertyName("collector_price_average_magnum_currency")]
    public object? CollectorPriceAverageMagnumCurrency { get; set; }

    [JsonPropertyName("collector_abv")]
    public object? CollectorAbv { get; set; }
}

public class Producer
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    [JsonPropertyName("background_image_url")]
    public object? BackgroundImageUrl { get; set; }

    [JsonPropertyName("elastic_last_synced")]
    public DateTime? ElasticLastSynced { get; set; }

    [JsonPropertyName("ws_producer_link")]
    public string? WsProducerLink { get; set; }

    [JsonPropertyName("ownership")]
    public string? Ownership { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}

public class CollectionResponse
{
    [JsonPropertyName("labels")]
    public List<Label>? Labels { get; set; }
}

public class Wine
{
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("wine_type")]
    public string? WineType { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("winery")]
    public string? Winery { get; set; }

    [JsonPropertyName("producer_id")]
    public string? ProducerId { get; set; }

    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }

    [JsonPropertyName("back_label_image_url")]
    public string? BackLabelImageUrl { get; set; }

    [JsonPropertyName("pairings")]
    public List<string>? Pairings { get; set; }

    [JsonPropertyName("is_approved")]
    public bool? IsApproved { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("livex_wine_type")]
    public object? LivexWineType { get; set; }

    [JsonPropertyName("livex_wine_name")]
    public string? LivexWineName { get; set; }

    [JsonPropertyName("livex_display_name")]
    public string? LivexDisplayName { get; set; }

    [JsonPropertyName("livex_display_name_type")]
    public string? LivexDisplayNameType { get; set; }

    [JsonPropertyName("parcel")]
    public object? Parcel { get; set; }

    [JsonPropertyName("subtype")]
    public string? Subtype { get; set; }

    [JsonPropertyName("classification")]
    public string? Classification { get; set; }

    [JsonPropertyName("synced_to_perfect_label")]
    public object? SyncedToPerfectLabel { get; set; }

    [JsonPropertyName("maturation")]
    public string? Maturation { get; set; }

    [JsonPropertyName("dosage")]
    public string? Dosage { get; set; }

    [JsonPropertyName("method")]
    public object? Method { get; set; }

    [JsonPropertyName("vineyard_notes")]
    public string? VineyardNotes { get; set; }

    [JsonPropertyName("winemaking")]
    public string? Winemaking { get; set; }

    [JsonPropertyName("sweetness")]
    public string? Sweetness { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("producer")]
    public Producer? Producer { get; set; }
}
