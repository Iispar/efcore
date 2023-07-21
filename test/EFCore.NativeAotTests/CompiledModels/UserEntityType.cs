// <auto-generated />
using System.Reflection;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.NativeAotTests.Models;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Microsoft.EntityFrameworkCore.NativeAotTests.CompiledModels
{
    internal partial class UserEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.NativeAotTests.Models.User",
                typeof(User),
                baseEntityType);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(User).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(User).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueComparer: ValueComparer.CreateDefault<int>(favorStructuralComparisons: false),
                providerValueComparer: ValueComparer.CreateDefault<int>(favorStructuralComparisons: true));
            id.SetSetter((User e, int v) => e.Id = v);
            id.SetGetter((User e) => e.Id, e => e.Id == default(int));
            id.SetAccessors(new PropertyAccessors(
                (InternalEntityEntry e) =>
                    ((User)e.Entity).Id == 0
                        ? e.FlaggedAsStoreGenerated(0)
                            ? e.ReadStoreGeneratedValue<int>(0)
                            : e.FlaggedAsTemporary(0)
                                ? e.ReadTemporaryValue<int>(0)
                                : ((User)e.Entity).Id
                        : ((User)e.Entity).Id,
                (InternalEntityEntry e) =>
                    ((User)e.Entity).Id == 0
                        ? e.ReadTemporaryValue<int>(0) == 0
                            ? ((User)e.Entity).Id
                            : e.ReadTemporaryValue<int>(0)
                        : ((User)e.Entity).Id,
                (InternalEntityEntry e) => e.ReadOriginalValue<int>(id, 0),
                (InternalEntityEntry e) => e.ReadRelationshipSnapshotValue<int>(id, 0),
                valueBuffer => valueBuffer[0]!));
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var name = runtimeEntityType.AddProperty(
                "Name",
                typeof(string),
                propertyInfo: typeof(User).GetProperty("Name", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(User).GetField("<Name>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueComparer: ValueComparer.CreateDefault<string>(favorStructuralComparisons: false),
                providerValueComparer: ValueComparer.CreateDefault<string>(favorStructuralComparisons: true));
            name.SetSetter((User e, string v) => e.Name = v);
            name.SetGetter((User e) => e.Name, e => e.Name == default(string));
            name.SetAccessors(new PropertyAccessors(
                (InternalEntityEntry e) => ((User)e.Entity).Name,
                (InternalEntityEntry e) => ((User)e.Entity).Name,
                (InternalEntityEntry e) => e.ReadOriginalValue<string>(name, 1),
                (InternalEntityEntry e) => e.ReadRelationshipSnapshotValue<string>(name, 1),
                valueBuffer => valueBuffer[1]!));
            name.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            // TODO: Also set DependentKeyValueFactory on the referencing FKs
            key.SetPrincipalKeyValueFactory(new SimplePrincipalKeyValueFactory<int>(key));
            key.SetIdentityMapFactory(sensitiveLoggingEnabled =>
                new IdentityMap<int>(key, ((IRuntimeKey)key).GetPrincipalKeyValueFactory<int>(), sensitiveLoggingEnabled));
            runtimeEntityType.SetPrimaryKey(key);

            runtimeEntityType.SetEmptyShadowValuesFactory(() => Snapshot.Empty);
            runtimeEntityType.SetShadowValuesFactory(_ => Snapshot.Empty);
            runtimeEntityType.SetOriginalValuesFactory(e => new Snapshot<int, string>(e.GetCurrentValue<int>(id), e.GetCurrentValue<string>(name)));
            runtimeEntityType.SetStoreGeneratedValuesFactory(() => new Snapshot<int>(default(int)));
            runtimeEntityType.SetRelationshipSnapshotFactory(e => new Snapshot<int, string>(e.GetCurrentValue<int>(id), e.GetCurrentValue<string>(name)));
            runtimeEntityType.SetTemporaryValuesFactory(e => new Snapshot<int>(default(int)));

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Users");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
