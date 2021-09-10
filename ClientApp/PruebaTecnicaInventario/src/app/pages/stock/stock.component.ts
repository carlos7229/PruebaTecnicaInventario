import { Component } from '@angular/core';
import 'devextreme/data/odata/store';
import { StockService } from 'src/app/api/services'; 

@Component({
  templateUrl: 'stock.component.html'
})

export class StockComponent {
  public allStock: AllStock[] = [];
  
  constructor(private stockService: StockService ) {
    this.stockService.apiStockGet().subscribe(res => {
       this.allStock = JSON.parse(res)
    }); 
  }
 
}
export class AllStock {
  id?: number;
  productId?: number;
  code?: string;
  product?: string;
  quantity?: number;
}
