import { AppComponent } from './app.component';
import { Routes, RouterModule } from '@angular/router';
import { ModuleWithProviders } from "@angular/core";
import { page2Component } from 'app/Page2/page2.component';
import { Page1Component } from './Page1/page1.component';

export const routes: Routes = [
    { path: '', redirectTo: 'Page1', pathMatch: 'full' },
    { path: 'Page1', component: Page1Component },
    { path: 'Page2', component: page2Component },
    { path: 'Page2/:id', component: page2Component}
];

export const appRoutingProviders: any[] = [

];


export const routing: ModuleWithProviders = RouterModule.forRoot(routes, { useHash: true });

