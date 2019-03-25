import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DashboardComponent } from './sections/dashboard/dashboard.component';
import { ClientsComponent } from './sections/clients/clients.component';
import { EcrsComponent } from './sections/ecrs/ecrs.component';

const routes: Routes = [
  { path: 'dashboard', component: DashboardComponent },
  { path: 'clients', component: ClientsComponent },
  { path: 'ecrs', component: EcrsComponent },

  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
