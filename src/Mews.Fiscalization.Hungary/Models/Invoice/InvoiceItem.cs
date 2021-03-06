﻿using Mews.Fiscalization.Hungary.Utils;
using System;

namespace Mews.Fiscalization.Hungary.Models
{
    public sealed class InvoiceItem
    {
        public InvoiceItem(
            DateTime consumptionDate,
            ItemAmounts totalAmounts,
            ItemAmounts unitAmounts,
            MeasurementUnit measurementUnit,
            Description description,
            int quantity,
            ExchangeRate exchangeRate = null,
            bool isDeposit = false)
        {
            ConsumptionDate = consumptionDate;
            TotalAmounts = Check.NotNull(totalAmounts, nameof(totalAmounts));
            UnitAmounts = Check.NotNull(unitAmounts, nameof(unitAmounts));
            MeasurementUnit = measurementUnit;
            Description = Check.NotNull(description, nameof(description));
            Quantity = quantity;
            ExchangeRate = exchangeRate;
            IsDeposit = isDeposit;
        }

        public DateTime ConsumptionDate { get; }

        public ItemAmounts TotalAmounts { get; }

        public ItemAmounts UnitAmounts { get; }

        public MeasurementUnit MeasurementUnit { get; }

        public Description Description { get; }

        public int Quantity { get; }

        public ExchangeRate ExchangeRate { get; }

        public bool IsDeposit { get; }
    }
}
