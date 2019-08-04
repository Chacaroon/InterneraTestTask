import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SellersDropdownComponent } from './sellers-dropdown.component';

describe('SellersDropdownComponent', () => {
  let component: SellersDropdownComponent;
  let fixture: ComponentFixture<SellersDropdownComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SellersDropdownComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SellersDropdownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
