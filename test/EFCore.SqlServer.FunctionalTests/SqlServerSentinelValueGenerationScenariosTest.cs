// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using NetTopologySuite.Geometries;

namespace Microsoft.EntityFrameworkCore;

public class SqlServerSentinelValueGenerationScenariosTest : SqlServerValueGenerationScenariosTestBase
{
    protected override string DatabaseName
        => "SqlServerSentinelValueGenerationScenariosTest";

    protected override Guid GuidSentinel
        => new("56D3784D-6F7F-4935-B7F6-E77DC6E1D91E");

    protected override int IntSentinel
        => 667;

    protected override uint UIntSentinel
        => 667;

    protected override IntKey IntKeySentinel
        => IntKey.SixSixSeven;

    protected override ULongKey ULongKeySentinel
        => ULongKey.Sentinel;

    protected override int? NullableIntSentinel
        => 667;

    protected override string StringSentinel
        => "667";

    protected override DateTime DateTimeSentinel
        => new(1973, 9, 3, 0, 3, 0);

    protected override NeedsConverter NeedsConverterSentinel
        => new(668);

    protected override GeometryCollection GeometryCollectionSentinel
        => GeometryFactory.CreateGeometryCollection(
            new Geometry[] { GeometryFactory.CreatePoint(new Coordinate(6, 7)) });

    protected override byte[] TimestampSentinel
        => new byte[] { 1, 1, 1, 1, 1, 1, 1, 1 };

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Blog>(
            b =>
            {
                b.Property(e => e.Id).Metadata.Sentinel = IntSentinel;
                b.Property(e => e.Name).Metadata.Sentinel = StringSentinel;
                b.Property(e => e.CreatedOn).Metadata.Sentinel = DateTimeSentinel;
                b.Property(e => e.GeometryCollection).Metadata.Sentinel = GeometryCollectionSentinel;
                b.Property(e => e.OtherId).Metadata.Sentinel = NullableIntSentinel;
                b.Property(e => e.NeedsConverter).Metadata.Sentinel = new NeedsConverter(IntSentinel);
            });
    }
}
