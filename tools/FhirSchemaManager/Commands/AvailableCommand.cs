﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;

namespace FhirSchemaManager.Commands
{
    public static class AvailableCommand
    {
        public static void Handler(Uri fhirServer)
        {
            Console.WriteLine($"--fhir-server {fhirServer}");
        }
    }
}
