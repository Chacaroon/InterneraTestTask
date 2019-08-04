import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DealsComponent } from './pages/deals/deals.component';
import { AddDealComponent } from './pages/add-deal/add-deal.component';


const routes: Routes = [
	{path: '', redirectTo: 'deals', pathMatch: 'full'},
	{path: 'deals', component: DealsComponent},
	{path: 'add', component: AddDealComponent}
];

@NgModule({
	imports: [RouterModule.forRoot(routes, {useHash: true})],
	exports: [RouterModule]
})
export class AppRoutingModule {
}
