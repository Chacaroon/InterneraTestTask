import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContextMenuModule, MenuModule } from '@progress/kendo-angular-menu';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/header/header.component';
import { DealsComponent } from './pages/deals/deals.component';
import { AddDealComponent } from './pages/add-deal/add-deal.component';
import { HttpClientModule } from '@angular/common/http';
import { GridModule, SharedModule } from '@progress/kendo-angular-grid';
import { ComboBoxModule, DropDownListModule } from '@progress/kendo-angular-dropdowns';
import { ReactiveFormsModule } from '@angular/forms';
import { ProductsDropdownComponent } from './components/products-dropdown/products-dropdown.component';
import { CustomersDropdownComponent } from './components/customers-dropdown/customers-dropdown.component';
import { SellersDropdownComponent } from './components/sellers-dropdown/sellers-dropdown.component';
import { NumericTextBoxModule } from '@progress/kendo-angular-inputs';
import { ButtonModule } from '@progress/kendo-angular-buttons';



@NgModule({
	declarations: [
		AppComponent,
		HeaderComponent,
		DealsComponent,
		AddDealComponent,
		ProductsDropdownComponent,
		CustomersDropdownComponent,
		SellersDropdownComponent
	],
	imports: [
		BrowserModule,
		AppRoutingModule,
		MenuModule,
		BrowserAnimationsModule,
		ContextMenuModule,
		HttpClientModule,
		GridModule,
		SharedModule,
		ComboBoxModule,
		ReactiveFormsModule,
		DropDownListModule,
		NumericTextBoxModule,
		ButtonModule
	],
	providers: [],
	bootstrap: [AppComponent]
})
export class AppModule {
}
