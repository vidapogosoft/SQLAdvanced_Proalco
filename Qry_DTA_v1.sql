
select comprobante.FechaEmision, comprobante.NumeroFactura, comprobante.NumeroAutorizacion, comprobante.ClienteNombre, comprobante.ClienteIdentificacion, factura.Subtotal, factura.TotalIva as IVA,  factura.TotalIce  as ICE,  factura.TotalIrbpnr  as IRBPNR, factura.TotalIva + factura.TotalIce + factura.TotalIrbpnr as Impuestos, comprobante.ImporteTotal
	from ComprobanteFactura comprobante
	left join Factura factura on (comprobante.NumeroFactura = factura.NumeroFactura and comprobante.IdEmpresa = factura.IdEmpresa)
	where comprobante.IdEmpresa = 1
	and comprobante.FechaEmision between '2000-01-01 00:00:00.000' and '2024-01-01 00:00:00.000'		
	and	comprobante.Estado = 'A'		
