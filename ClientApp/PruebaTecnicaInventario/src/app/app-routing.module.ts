import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ClientsComponent } from './pages/clients/clients.component'; 
import { ProductsComponent } from './pages/products/products.component';
import { StockComponent } from './pages/stock/stock.component';
import { SalesComponent } from './pages/sales/sales.component';
import { DxDataGridModule, DxFormModule, DxButtonModule, DxToastModule, DxSelectBoxModule } from 'devextreme-angular';

const routes: Routes = [
  {
    path: 'clients',
    component: ClientsComponent,
  },
  {
    path: 'products',
    component: ProductsComponent,
  },
  {
    path: 'stock',
    component: StockComponent,
  },
  {
    path: 'sales',
    component: SalesComponent,
  },
  {
    path: 'home',
    component: HomeComponent,
  },
  {
    path: '**',
    redirectTo: 'home'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true }), DxDataGridModule, DxFormModule, DxButtonModule, DxToastModule, DxSelectBoxModule],
  providers: [],
  exports: [RouterModule],
  declarations: [HomeComponent, ClientsComponent, ProductsComponent, StockComponent, SalesComponent]
})
export class AppRoutingModule { }
