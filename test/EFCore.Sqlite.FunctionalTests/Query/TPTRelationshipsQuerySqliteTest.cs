// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.Query;

public class TPTRelationshipsQuerySqliteTest :
    TPTRelationshipsQueryTestBase<TPTRelationshipsQuerySqliteTest.TPTRelationshipsQuerySqliteFixture>
{
    public TPTRelationshipsQuerySqliteTest(TPTRelationshipsQuerySqliteFixture fixture)
        : base(fixture)
    {
    }

    public class TPTRelationshipsQuerySqliteFixture : TPTRelationshipsQueryRelationalFixture
    {
        protected override ITestStoreFactory TestStoreFactory
            => SqliteTestStoreFactory.Instance;
    }
}
