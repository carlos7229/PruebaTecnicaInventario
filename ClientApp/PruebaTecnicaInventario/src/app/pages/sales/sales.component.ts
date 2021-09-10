import { Component } from '@angular/core';
import 'devextreme/data/odata/store';
import { SaleService } from 'src/app/api/services'; 

@Component({
  templateUrl: 'sales.component.html'
})

export class SalesComponent {
  public sales: AllSales[] = [];
  
  constructor(private saleService: SaleService ) {
    this.saleService.apiSaleGet().subscribe(res => {
       this.sales = JSON.parse(res)
    }); 
  }
 
}
export class AllSales {
  id?: number;
  code?: string;
  product?: string;
  quantity?: number;
  saleValue?: number;
  saleDate?: string;
}
