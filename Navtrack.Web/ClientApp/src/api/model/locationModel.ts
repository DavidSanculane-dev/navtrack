/**
 * Generated by orval v6.5.1 🍺
 * Do not edit manually.
 * Navtrack.Api
 * OpenAPI spec version: 1.0
 */

export interface LocationModel {
  id?: string | null;
  latitude: number;
  longitude: number;
  coordinates: number[];
  readonly validCoordinates: boolean;
  dateTime: string;
  speed?: number | null;
  heading?: number | null;
  altitude?: number | null;
  satellites?: number | null;
  hdop?: number | null;
  valid?: boolean | null;
  gsmSignal?: number | null;
  odometer?: number | null;
}
